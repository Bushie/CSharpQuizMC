using System;
using System.Collections.Generic;

namespace QuizLibrary
{
    public class QuestionSix
    {
        private static int index = 0;

        public void Question()
        {
            Console.WriteLine(" Does C# have global variables?\n");



            List<string> possibleAnswers = new List<string>()
            {
                " Only if you use the G_Selector",
                " Yes",
                " C# does not have methods",
                " No",

            };

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(possibleAnswers);
                if (questionAnswerItems == " No")
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n Correct!\n");
                    Console.ResetColor();

                    //QuestionThree questionThree = new QuestionThree();
                    //questionThree.Question();
                }
                else if (questionAnswerItems != " No")
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
















