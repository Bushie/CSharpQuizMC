using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public class GraphicAtTheEndOfGame
    {
        public static ConsoleKeyInfo keypress = new ConsoleKeyInfo();

        public static void EndTitle()
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline

            string title =
                @"
                               
                     

                 __ _  ____  ____  ____    ____  ____   __    ___  ____  __  __ _   ___ 
                (  / )(  __)(  __)(  _ \  (  _ \(  _ \ / _\  / __)(_  _)(  )(  ( \ / __)
                 )  (  ) _)  ) _)  ) __/   ) __/ )   //    \( (__   )(   )( /    /( (_ \
                (__\_)(____)(____)(__)    (__)  (__\_)\_/\_/ \___) (__) (__)\_)__) \___/

                 


                ";

            Console.WriteLine(title);
            Console.WriteLine("  Press 1 to close screen");
            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.D1)
                Environment.Exit(0);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

