using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary.Questions
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }

        private int index = 0;

        public void Show()
        {
            Console.WriteLine(QuestionText);

            Console.CursorVisible = false;
            while (true)
            {
                string questionAnswerItems = QuestionScrollFunctionality(Answers);
                if (questionAnswerItems == CorrectAnswer)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Correct, {CorrectAnswer}\n");
                    Console.ResetColor();
                    break;
                }
                else if (questionAnswerItems != CorrectAnswer)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" \n Wrong answer");
                    Console.Write(" \n Select another choice, then press enter\n\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(QuestionText);
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
                    index = 0; 
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
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
