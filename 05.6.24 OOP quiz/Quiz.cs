using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _05._6._24_OOP_quiz
{
    
    class Quiz
    {
        private int _score = 0;
        private int _qcount;
        private List<Questions> _questions = new List<Questions>();

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public int Qcount
        {
            get { return _qcount; }
            set { _qcount = value; }
        }
        public int QTotal
        {
            get { return _questions.Count; }
        }
        public int QLeft
        {
            get { return _questions.Count - (_qcount + 1); }
        }
        public Quiz()
        {
            StreamReader questions = new StreamReader("Questions for oop.txt");
            string line = "";

            while (!questions.EndOfStream)
            {
                line = questions.ReadLine();
                Questions ques = new Questions(line);
                _questions.Add(ques);
            }
        }
        public Boolean CheckAnswer(int answer)
        {
            if (answer == _questions[_qcount - 1].Correct)
            {
                Score++;
                return true;
            }
            else
            {
                return false;
            }

        }
        public Questions GetNextQuestion()
        {
            if (_qcount < _questions.Count)
            {
                _qcount++;
                return _questions[_qcount - 1];
            }
            else
            {
                return null;
            }
        }
        public Questions GetQuestion(int q)
        {
            if (q < _questions.Count)
            {

                return _questions[q];
            }
            else
            {
                return null;
            }
        }
    }
}
