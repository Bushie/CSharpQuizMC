using QuizLibrary;
using QuizLibrary.Questions;
using System;
using System.Collections.Generic;

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
        var questions = new List<Question>
        {
            new Question
            {
                QuestionText = "1. When was C# invented?\n",
                Answers = new List<string>
                {
                    " 1983",
                    " 2002",
                    " 2000",
                    " 1995",
                    " 2012"
                },
                CorrectAnswer = " 2000"
            },

            new Question()
            {
                QuestionText = " 2. Who created C#?\n",
                Answers = new List<string>
                {
                    " Guido van Rossum",
                    " Ken Thompson",
                    " James Gosling",
                    " Bjarne Stroustrup",
                    " Anders Hejlsberg"
                }, 
                CorrectAnswer = " Anders Hejlsberg"
            },

            new Question()
            {
                QuestionText = " 3. Is C# a complied language?\n",
                Answers = new List<string>
                {
                    " No",
                    " Yes",
                    " Dynamic",
                    " OOP",
                    " Hybrid"

                },
                CorrectAnswer = " Yes"
            },

            new Question()
            {
                QuestionText = " 4. Does C# allow mutliple inheritance?\n",
                Answers = new List<string>
                {
                    " Delegate",
                    " Yes",
                    " Super Class",
                    " No",
                    " Hybrid"

                },
                CorrectAnswer = " No"
            },

            new Question()
            {
                QuestionText = " 5. Is method overloading just another name for method overriding?\n",
                Answers = new List<string>
                {
                    " They can be swapped",
                    " Yes",
                    " No",
                    " C# does not have methods"


                },
                CorrectAnswer = " No"
            },

            new Question()
            {
                QuestionText = " 6. Does C# have global variables?\n",
                Answers = new List<string>
                {
                    " Only if you use the G_Selector",
                    " Yes",
                    " C# does not have methods",
                    " No",


                },
                CorrectAnswer = " No"
            },


        };

            GraphicAtTheStartOfGame.StartTitle();

            foreach (var question in questions)
            {
                question.Show();
            }

            GraphicAtTheEndOfGame.EndTitle();
        }
      
    }
}




