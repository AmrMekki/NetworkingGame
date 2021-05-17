using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerClient
{
    /*1-
3- connect client to new network
4- send string from server to each player to know questions and answers, then another to send scores
5- timer for client (optional)
*/
    public partial class frmPlayer : Form
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


        Point lastPoint;
        private static Socket clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        string PlayerName;
        byte[] buffer = new byte[1024];
        byte[] receivedBuff = new byte[1024];
        public frmPlayer(string playerName)
        {
            InitializeComponent();

            //Region codes are for rounded rectangle GUI
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            btnA.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnA.Width, btnA.Height, 30, 30));
            btnB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnB.Width, btnB.Height, 30, 30));
            btnC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnC.Width, btnC.Height, 30, 30));
            btnD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnD.Width, btnD.Height, 30, 30));
            pnlQuestions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlQuestions.Width, pnlQuestions.Height, 30, 30));


            PlayerName = playerName;
            lblPlayerName.Text = $"Player: {playerName}";
            //player sends name first
            ProgressBar1.Value = 100;
            disableBtn();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            SendSend("a");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            SendSend("b");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            SendSend("c");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            SendSend("d");   
        }

        private void SendSend(string answer)
        {
            buffer = Encoding.UTF8.GetBytes(answer);
            disableBtn();
            try
            {
                clientSocket.Send(buffer);
            }
            catch
            {
                MessageBox.Show("Server Discconected.");
                Application.Exit();
            }


            //server will send scores

            Task<int> taskScore = new Task<int>(ReceiveMessage);
            taskScore.Start();


            Task<int> taskQuestion = new Task<int>(ReceiveMessage);
            taskQuestion.Start();


        }

        private void disableBtn()
        {
            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = false;
        }
        private void enableBtn()
        {
            this.Invoke((MethodInvoker)delegate
            {
                btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = true;
            });
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

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //later we will bind client too
                clientSocket.Connect(IPAddress.Parse(txtIP.Text), 9000);
                
                byte[] buffer = Encoding.UTF8.GetBytes(PlayerName);
                //send player name to server
                clientSocket.Send(buffer);


                lblConnected.Text = "Connected to Server.";
                lblConnected.ForeColor = System.Drawing.Color.Lime;
                btnConnect.Enabled = false;
                Task<int> task = new Task<int>(ReceiveMessage);
                task.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ReceiveMessage()
        {
            try
            {
                //now wait to receive first question
                byte[] receivedBuff = new byte[1024];
                int rec = clientSocket.Receive(receivedBuff);
                byte[] data = new byte[rec];
                Array.Copy(receivedBuff, data, rec);
                string temp = Encoding.UTF8.GetString(data);

                if (temp[0] == '0')
                {

                    string[] scoreList = temp.Split('/');
                    scoreList[0] = new string(RemoveFirst(scoreList[0].ToCharArray()));
                    UpdateScore(scoreList);

                }
                else
                {
                    string[] questionList = temp.Split('/');
                    UpdateQuestion(questionList);
                    enableBtn();
                }

            }
            catch
            {
                MessageBox.Show("Server Disconnected.");
                Application.Exit();
            }
            return 0;
        }

        private void UpdateScore(string[] scoreList)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //try until error happens
                try
                {
                    lblP1.Text = scoreList[0];
                    lblP2.Text = scoreList[1];
                    lblP3.Text = scoreList[2];
                    lblP4.Text = scoreList[3];
                    lblP5.Text = scoreList[4];
                    lblP6.Text = scoreList[5];
                }
                catch
                {
                    //doesn't show anything but exits the function
                }


            });
        }

        private char[] RemoveFirst(char[] playersString)
        {
            for(int i=0; i < playersString.Length - 1; i++)
            {
                playersString[i] = playersString[i + 1];

            }
            playersString[playersString.Length - 1] = '\0';

            return playersString;
        }

        private void UpdateQuestion(string[] questionList)
        {
            this.Invoke((MethodInvoker)delegate
            {
                
                labelQuestion.Text = questionList[0];
                btnA.Text = questionList[1];
                btnB.Text = questionList[2];
                btnC.Text = questionList[3];
                btnD.Text = questionList[4];
            });
        }
    }
}
