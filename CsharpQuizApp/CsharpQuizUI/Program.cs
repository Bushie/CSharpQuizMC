
using System;

namespace CsharpQuizUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGameGraphic();

            QuestionsUserInteractWith();

            EndGameraphic();

            Console.ReadLine();
        }

        private static void EndGameraphic()
        {
            GraphicAtTheEndOfGame graphicAtTheEndOfGame = new GraphicAtTheEndOfGame();
            graphicAtTheEndOfGame.EndTitle();
        }

        private static void QuestionsUserInteractWith()
        {
            UserInteractsWithQuiz userInteractsWithQuiz = new UserInteractsWithQuiz();
            userInteractsWithQuiz.CsharpQuizQuestions();
        }

        private static void StartGameGraphic()
        {
            GraphicAtTheStartOfGame graphicAtTheStartOfGame = new GraphicAtTheStartOfGame();
            graphicAtTheStartOfGame.StartTitle();
        }
    }
}




