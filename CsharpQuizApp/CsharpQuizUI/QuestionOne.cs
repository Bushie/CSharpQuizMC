using System;
using System.Collections.Generic;

namespace CsharpQuizUI
{
    public class QuestionOne
    {
        private static int index = 0;

        public void Question()
        {
            Console.WriteLine(" When was C# invented?\n");



            List<string> possibleAnswers = new List<string>()
            {
                " 1983",
                " 2002",
                " 2000",
                " 1995",
                " 2012"

            };

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(possibleAnswers);
                if (questionAnswerItems == " 2000")
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n Correct!\n");
                    Console.ResetColor();

                    QuestionTwo questionTwo = new QuestionTwo();
                    questionTwo.Question();
                }
                else if (questionAnswerItems != " 2000")
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" \n Wrong answer\n");
                    Console.ResetColor();


                }

            }

        }

    /// <summary>
    /// Creates scrolling affect
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
        public string QuestionScrollFunctionality(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }


    }
}
















