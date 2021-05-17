using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostServer
{
    class Player
    {
        //we can add preferred name for each player

        //counter we don't need but it is used to increment player number
        private static int m_Counter = 0;
        private int playerNumber;
        private string playerName;
        private string ipPort;
        private int score;
        private int order;
        private char answer;


        public string IpPort { get => ipPort; set => ipPort = value; }
        public int PlayerNumber { get => playerNumber; set => playerNumber = value; }
        public int Score { get => score; set => score = value; }
        public int Order { get => order; set => order = value; }
        public char Answer { get => answer; set => answer = value; }
        public string PlayerName { get => playerName; set => playerName = value; }

        //no arg constructor
        public Player()
        {

        }

        //ipPort constructor
        public Player(string ipPort , string playerName)
        {
            IpPort = ipPort;
            PlayerName = playerName;
            PlayerNumber = System.Threading.Interlocked.Increment(ref m_Counter);
            Score = 0;
        }

    }
}
