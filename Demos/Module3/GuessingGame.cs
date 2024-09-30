/*
Write a program named GuessingGame that generates a random number between 1 and 10.
(In other words, in the example above, min is 1 and max is 11.)

Ask a user to guess the random number, then display the random number and a message indicating
whether the user's guess was too high, too low, or correct.

 */



using System;
using System.Transactions;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module3
{
    internal class GuessingGame
    {
        static void Main()
        {
            //Declaration 
            const int MIN = 1;  //lower bound is inclusive
            const int MAX = 11; //upper bound is exclusive

            //Two numbers
            int randomNum, guess;

            //Generate a random number
            Random rand = new Random();  //Random is a class, New starts the instantiation process.
            randomNum = rand.Next(MIN, MAX);  //Use one of the use cases of an overloaded method.  
            

            //Input procedure
            Write("Please enter an integer between 1 and 10: ");
            guess = Convert.ToInt32(ReadLine());

            //Do this after the user guess 
            WriteLine($"The random is {randomNum}.");

            //Processing

            //Decision-making
            //option 1 - nested IFs.
            if (guess > randomNum)
                WriteLine("Too high!");
            else
                if (guess < randomNum)
                    WriteLine("Too low");
                else
                    WriteLine("Correct! :)");

            //Option 2 - if..elseif...else block (more efficient!)
            if (guess > randomNum)
                WriteLine("Too high!");
            else if (guess < randomNum)
                WriteLine("Too low");
            else
                WriteLine("Correct! :)");

            //Tips:

            // Translation examples of comparsion symbols

            // over >
            // under <
            // at least >=
            // within <=
            // does not exceed <=

            // (hired) on or after >=
            // (hired) after >
            // (hired) before <
            // (hired) before or on <=

        }
    }
}
