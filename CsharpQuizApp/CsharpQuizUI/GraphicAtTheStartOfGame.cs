using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpQuizUI
{
    public class GraphicAtTheStartOfGame
    {
        public static ConsoleKeyInfo keypress = new ConsoleKeyInfo();

        public void StartTitle()
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline

            string title =
                @"
                               
                     

               
  
  
                ╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐  ╔═╗  ─┼─┼─  ╔═╗ ┬ ┬┬┌─┐
                ║║║├┤ │  │  │ ││││├┤    │ │ │  ║    ─┼─┼─  ║═╬╗│ ││┌─┘
                ╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘  ╚═╝         ╚═╝╚└─┘┴└─┘


                ";

            Console.WriteLine(title);
            Console.ResetColor();
         
        }
    }
}


                                                                                         


                 

