using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._6._24_OOP_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz myquiz = new Quiz();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to My Quiz!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nWould you like to enter?(y/n): ");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            while(myquiz.QLeft != 0)
            {
                Questions ques = myquiz.GetQuestion(myquiz.Qcount);
                Console.WriteLine($"({myquiz.Qcount+1}){(ques.QuestionTxt)}");
                Console.WriteLine($"1){ques.Answer1}");
                Console.WriteLine($"2){ques.Answer2}");
                Console.WriteLine($"3){ques.Answer3}");
                Console.WriteLine($"4){ques.Answer4}");
                Console.ReadLine();
            }
            
        }
    }
}


        

            
    



            
        
    
