using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostServer
{
    class Questions
    {
        private string question;
        private string a;
        private string b;
        private string c;
        private string d;
        private char rightAnswer;
        private string category;
        private int time;

        public string Question { get => question; set => question = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public char RightAnswer { get => rightAnswer; set => rightAnswer = value; }
        public string Category { get => category; set => category = value; }
        public int Time { get => time; set => time = value; }

        //no arg constructor
        public Questions()
        {

        }


        //arg constructor
        public Questions(string question, string a, string b, string c, string d, char rightAnswer)
        {
            Question = question;
            A = a;
            B = b;
            C = c;
            D = d;
            RightAnswer = rightAnswer;
        }

        public List<Questions> LoadQuestions(List<Questions> listQuestions)
        {
            string currentline;
            string character;
            using (StreamReader streamReader = new StreamReader(@"questions.txt"))
            {
                while (true)
                {
                    Questions question = new Questions();
                    currentline = streamReader.ReadLine();


                    if (currentline == "question")
                    {
                        question.Question = streamReader.ReadLine();
                        question.A = streamReader.ReadLine();
                        question.B = streamReader.ReadLine();
                        question.C = streamReader.ReadLine();
                        question.D = streamReader.ReadLine();
                        character = streamReader.ReadLine(); //put string in array
                        question.RightAnswer = character[0]; //then take first index for character
                        question.Category = streamReader.ReadLine();
                        question.Time = int.Parse(streamReader.ReadLine());

                        listQuestions.Add(question);
                    }
                    if (currentline == null)
                        break;
                }
            }
            return listQuestions;
        }


    }
}
