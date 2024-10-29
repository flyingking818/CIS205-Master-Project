/*
Print numbers from 1 to 5, but using a different type of loop.
 */


using System;
using System.Reflection.Metadata;
using static System.Console;
class OddNums
{
    static void Main()
    {
        const int LIMIT = 5;
        //1. While Loop
        int i = 1;
        while (i <= LIMIT)
        {            
            WriteLine(i);
            i++;
        }

        //2. Do While Loop - the loop body will be executed at once!
        i = 1;
        do
        {            
            WriteLine(i);  //1 will always be displayed!
            i++;
        } while (i <= LIMIT);

        //3. For loop - recommended for definite loops!
        
        for (int i = 1; i <= LIMIT; i++)
        {
            WriteLine(i);
        }
        

        //4. Foreach loop - great for looping through a collection/array.No need for a counter!
        
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)  //no need to worry about the counter!
        {
            WriteLine("Hello Word! :)");
            WriteLine(num);
        }
    }
}