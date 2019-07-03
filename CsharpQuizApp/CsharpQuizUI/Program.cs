using System;

namespace CsharpQuizUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Quiz will appear soon\n");

            QuestionOne questionOne = new QuestionOne();
            questionOne.Question();

            QuestionTwo questionTwo = new QuestionTwo();
            questionTwo.Question();

            QuestionThree questionThree = new QuestionThree();
            questionThree.Question();

           

            Console.Clear();

            Console.ReadLine();
        }
    }
}
