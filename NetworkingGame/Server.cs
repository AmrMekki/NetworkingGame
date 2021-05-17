using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HostServer
{
    public partial class Server : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        private static byte[] buffer = new byte[1024]; //we don't need more because we're sending simple messages
        private static List<Socket> clientSockets = new List<Socket>(); //list of sockets that contains connected clients
        private static Socket serverSocket = new Socket //server socket that we will bind to with TCP connection
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //parameters( working on ip version 4,  how we send the data based on the protocol, protocol tcp)



        List<Player> listPlayer = new List<Player>(); //list of players that scores all data about players
        List<Questions> listQuestions = new List<Questions>(); //list of uploaded questions
        Questions tempQuestions = new Questions(); //to hold the current question being used
        String temporaryString = ""; //String that stores received data temporarily 
        String scoreString = ""; //String that stores received data temporarily 
        int Order = 1; //to order players (first to answer   till last to answer)


        //Point to store screen position
        Point lastPoint;
         
        public Server()
        {
            InitializeComponent();

            //Region codes are for rounded rectangle GUI
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            btnA.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnA.Width, btnA.Height, 30, 30));
            btnB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnB.Width, btnB.Height, 30, 30));
            btnC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnC.Width, btnC.Height, 30, 30));
            btnD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnD.Width, btnD.Height, 30, 30));
            pnlQuestions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlQuestions.Width, pnlQuestions.Height, 30, 30));

            //to start the app with 100 progress bar
            ProgressBar1.Value = 100;

        }

        private void Server_Load(object sender, EventArgs e)
        {
            //disable these buttons until we start our server
            btnQuestion.Enabled = false;
            btnStartRound.Enabled = false;
            btnEndRound.Enabled = false;


            //loading questions in file
            tempQuestions.LoadQuestions(listQuestions);

            //adding questions to our list
            foreach (Questions questions in listQuestions)
            {
                lstQuestions.Items.Add(questions.Question);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtInfo.Text += $"Setting up server...{Environment.NewLine}";

            if (txtIP.Text == "")
            {
                MessageBox.Show("Please enter your IP");
            }
            else
            {
                try
                {
                    //binding on computer ip with chosen port
                    serverSocket.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text), 9000));
            
                    txtInfo.Text += $"Server successfully set up.{Environment.NewLine}";
            
                    //so we can't bind anymore
                    btnStart.Enabled = false;

                    //now we can choose our question
                    btnQuestion.Enabled = true;

                    serverSocket.Listen(5); //backlog: amount of uncompleted work
                     //now we start our AsyncCallback
                    serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Connection Message: " + ex.ToString());
                }
                
            }

        }

        private void AcceptCallback(IAsyncResult AR)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //take client info into socket and add them to clients's list
                Socket socket = serverSocket.EndAccept(AR);
                clientSockets.Add(socket);

               
                //start receiving from this specific client
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

                //to accept connections from other clients
                serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);

            });
        }
        public void ReceiveCallback(IAsyncResult AR)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //take client info into socket
                Socket socket = (Socket)AR.AsyncState;

                try
                {

                   
                    //to take the data from client, count the bytes
                    int received = socket.EndReceive(AR);
                    byte[] dataBuff = new byte[received];
                    Array.Copy(buffer, dataBuff, received);

                    //to turn bytes into string
                    temporaryString = Encoding.UTF8.GetString(dataBuff); //a or b or c or d


                    if (temporaryString.Length > 1)
                    {
                        //to add this client to our list, and say he is connected
                        ClientConnected(socket.RemoteEndPoint.ToString() , temporaryString);
                    }

                    else
                    {
                        foreach (Player player in listPlayer)
                        {
                            //this function is to show sent from players, we will change it with the operation of correct answers
                            if (player.IpPort == socket.RemoteEndPoint.ToString())
                            {
                                //puts the number of player in a strnig to know its order
                                scoreString += $"{player.PlayerNumber}";

                                txtInfo.Text += $"{player.PlayerName}: " +
                                $"{Encoding.UTF8.GetString(dataBuff)}{Environment.NewLine}";
                                player.Answer = temporaryString[0];

                            }
                        }
                    }

                    //start waiting to receive from client
                    socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

                }
                catch
                {
                    Player playerDisconnected = new Player();
                    if (!socket.Connected)
                    {
                        foreach(Player player in listPlayer)
                        {
                            if (player.IpPort == socket.RemoteEndPoint.ToString())
                            {
                                txtInfo.Text += $"{player.PlayerName} has disconnected.{Environment.NewLine}";
                                playerDisconnected = player;
                            }
                        }

                        listPlayer.Remove(playerDisconnected);
                        clientSockets.Remove(socket);
                    }
                }
            });

        }


        public void ClientConnected(string ip , string name)
        {
            //if the client connects, we will display its number and add it to our lists
            this.Invoke((MethodInvoker)delegate
            {
                Player player = new Player(ip , name);
                txtInfo.Text += $"{player.PlayerName} has connected. {Environment.NewLine}";
                listPlayer.Add(player);
                UpdateLabels();
            });
        }

        //changing labels according to updates
        private void UpdateLabels()
        {
            foreach (Player player in listPlayer)
            {
                switch (player.PlayerNumber)
                {
                    case 1:
                        lblP1.Text = $"{player.PlayerName}: {player.Score}";
                        break;
                    case 2:
                        lblP2.Text = $"{player.PlayerName}: {player.Score}";
                        break;
                    case 3:
                        lblP3.Text = $"{player.PlayerName}: {player.Score}";
                        break;
                    case 4:
                        lblP4.Text = $"{player.PlayerName}: {player.Score}";
                        break;
                    case 5:
                        lblP5.Text = $"{player.PlayerName}: {player.Score}";
                        break;
                    case 6:
                        lblP6.Text = $"{player.PlayerName}: {player.Score}";
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            foreach (Questions questions in listQuestions)
            {
                if (questions.Question == lstQuestions.SelectedItem.ToString())
                {
                    labelQuestion.Text = questions.Question;
                    btnA.Text = questions.A;
                    btnB.Text = questions.B;
                    btnC.Text = questions.C;
                    btnD.Text = questions.D;
                    lblAnswer.Text = $"The correct answer is {questions.RightAnswer}";
                }
            }
            btnStartRound.Enabled = true;
        }

        private void btnEndRound_Click(object sender, EventArgs e)
        {

            Order = 1;
            int tempScore = listPlayer.Count * 100; //600,500,400,300,200,100 depending on number of players

            //this foreach puts the current question in tempQuestion object
            foreach (Questions questions in listQuestions)
            {
                if (lstQuestions.SelectedItem.ToString() == questions.Question)
                    tempQuestions = questions;
            }

            //to delete the chosen question from the list
            for (int i = 0; i < lstQuestions.Items.Count; i++)
            {
                string removelistitem = tempQuestions.Question;
                if (lstQuestions.Items[i].ToString().Contains(removelistitem))
                {
                    lstQuestions.Items.RemoveAt(i);
                }
            }

            //use scoreString to order players then make scoreString empty
            scoreString = OrderPlayer(scoreString);

            //now we put the right scores for each player according to their order
            while (Order <= listPlayer.Count)
            {
                foreach (Player player in listPlayer)
                {
                    
                    if (player.Order == Order)
                    {
                        if (player.Answer == tempQuestions.RightAnswer)
                        {
                            player.Score += tempScore;
                            tempScore -= 100;
                        }
                        Order++;
                    }
                }
            }
            UpdateLabels();
            SendScore();
            //now we can start another round
            btnQuestion.Enabled = true;
            lstQuestions.Enabled = true;
            btnEndRound.Enabled = false;
        }

        private string OrderPlayer(string scoreString)
        {
            scoreString = DisconnectedClient(scoreString);

            for(int i = 0; i < scoreString.Length; i++)
            {
                foreach(Player player in listPlayer)
                {
                    if (player.PlayerNumber == int.Parse(scoreString[i].ToString()))
                    {
                        player.Order = i+1;
                    }
                }
            }
            return scoreString = "";
        }

        private string DisconnectedClient(string scoreString)//231
        {
            int k = 0;
            for (int i = 0; i < scoreString.Length; i++) {

                foreach (Player player in listPlayer)
                {
                    if (player.PlayerNumber == int.Parse(scoreString[i].ToString()))
                        k = 1;
                }
                if (k == 0)
                {
                    scoreString = new string(RemoveFromIndex(scoreString.ToCharArray(), i));
                    i--;
                }
                k = 0;
            }

            return scoreString;
        }

        //choose from index a char to remove
        private char[] RemoveFromIndex(char[] scoreString, int i)
        {
            while (i < scoreString.Length - 1)
            {
                scoreString[i] = scoreString[i + 1];

                i++;
            }
            scoreString[i] = '\0';
            return scoreString;
        }

        private void SendScore()
        {
            string scoreString="0";
            foreach (Player player in listPlayer)
            {
                scoreString += $"{player.PlayerName}: {player.Score}/";
            }
            byte[] bufferScore = Encoding.UTF8.GetBytes(scoreString);

            foreach (Socket socket in clientSockets)
            {
                socket.Send(bufferScore);
            }
        }

        private void btnStartRound_Click(object sender, EventArgs e)
        {
            //here we will code how the questions and the times will reach the players
            foreach(Questions questions in listQuestions)
            {
                if(questions.Question == lstQuestions.SelectedItem.ToString())
                {
                    tempQuestions = questions;
                }
            }

            //loop all players to reset their answers for tthe next round
            foreach(Player player in listPlayer)
            {
                player.Answer = 'f';
            }

            //the string that we will send to players including the question info
            string questionString=
                $"{tempQuestions.Question}/" +
                $"{tempQuestions.A}/" +
                $"{tempQuestions.B}/" +
                $"{tempQuestions.C}/" +
                $"{tempQuestions.D}/" +
                $"{tempQuestions.Category}/" +
                $"{tempQuestions.Time}";
            byte[] bufferSend = Encoding.UTF8.GetBytes(questionString);

            foreach(Socket socket in clientSockets)
            {
                socket.Send(bufferSend);
            }
            btnEndRound.Enabled = true;
            btnQuestion.Enabled = false;
            lstQuestions.Enabled = false;
            btnStartRound.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //each tick we decrease the progress bar
            ProgressBar1.Value -= 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString();

            if (ProgressBar1.Value == 0)
            {
                timer1.Enabled = false;
            }
        }

        private void Server_MouseDown(object sender, MouseEventArgs e)
        {

            //statement to move screen with cursor
            lastPoint = new Point(e.X, e.Y);
        }

        private void Server_MouseMove(object sender, MouseEventArgs e)
        {
            //statement to move screen with cursor
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }


}
