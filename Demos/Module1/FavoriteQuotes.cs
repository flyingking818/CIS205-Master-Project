using System;
using static System.Console; //This should be added for all console programs

namespace CIS205_Master_Project.Demos
{
    internal class FavoriteQuotes
    {
        //Don't forget to add the main
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Clear();

            //Output of my favorite quotes
            WriteLine("My favorite quotes are: ");
            WriteLine("\t\tapple a day keeps the doctors away! :)");
            Write("Another quote:\n");

        }
    }
}
