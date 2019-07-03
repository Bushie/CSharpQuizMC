
using QuizLibrary;
using System;


namespace CsharpQuizUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CsharpQuizQuestions();

            Console.ReadLine();
        }

        private static void CsharpQuizQuestions()
        {
            GraphicAtTheStartOfGame.StartTitle();

            QuestionOne questionOne = new QuestionOne();
            questionOne.Question();

            QuestionTwo questionTwo = new QuestionTwo();
            questionTwo.Question();

            QuestionThree questionThree = new QuestionThree();
            questionThree.Question();

            QuestionFour questionFour = new QuestionFour();
            questionFour.Question();

            QuestionFive questionFive = new QuestionFive();
            questionFive.Question();

            QuestionSix questionSix = new QuestionSix();
            questionSix.Question();

            Console.Clear();
        }
    }
}




