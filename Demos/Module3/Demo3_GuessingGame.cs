/* 
 Write a program named GuessingGame that generates a random number between 1 and 10. 
(In other words, in the example above, min is 1 and max is 11.) 

Ask a user to guess the random number, then display the random number and a message indicating 
whether the user’s guess was too high, too low, or correct. 
 */


using System;
using static System.Console;
class GuessingGame
{
   static void Main()
   {
        const int MIN = 1;
        const int MAX = 11;

        int randomNumber;
        int guess;

        Write("Please enter your guess: ");
        guess = Convert.ToInt32(ReadLine());

        Random random = new Random();
        randomNumber = random.Next(MIN, MAX);

        WriteLine("The randomm number is {0}", randomNumber);
        if (guess > randomNumber)
        { 
            WriteLine("Too high!"); 
        }           
        else
        {
            if (guess < randomNumber)
                WriteLine("Too low!");
            else
                WriteLine("Great guess!");
        }
           



    
   }
}
