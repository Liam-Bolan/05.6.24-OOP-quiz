using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._6._24_OOP_quiz
{
    class Questions
    {
        private string _Q;
        private string _A1;
        private string _A2;
        private string _A3;
        private string _A4;
        private int _correct;

        public string QuestionTxt
        {
            get { return _Q; }
            set { _Q = value; }
        }
        public string Answer1
        {
            get { return _A1; }
            set { _A1 = value; }
        }
        public string Answer2
        {
            get { return _A2; }
            set { _A2 = value; }
        }
        public string Answer3
        {
            get { return _A3; }
            set { _A3 = value; }
        }
        public string Answer4
        {
            get { return _A4; }
            set { _A4 = value; }
        }
        public int Correct
        {
            get { return _correct; }
            set { _correct = value; }
        }
        public Questions(string stringin) //constructor
        {
            string[] DataIn = stringin.Split(',');
            _Q = DataIn[0];
            _A1 = DataIn[1];
            _A2 = DataIn[2];
            _A3 = DataIn[3];
            _A4 = DataIn[4];
            _correct = int.Parse(DataIn[5]);
        }
    }
}


