using System;
using static System.Console;
class ArrayBasics
{

    static void Main()
    {
        /*=================================Array basics==================*/
        //--------1. How to declare array object?----------
        // 2 lines - declare and initialize, separately.
        double[] sales;
        sales = new double[20];
        WriteLine(sales.Length);  //this represents the size, dimension of the array

        // 1 lines - declare and initialize, together. - Recommended.
        string[] studentNames = new string[10]; // null
        bool[] isPassingGrade = new bool[10];   // false   int - 0


        //--------2. How to initialize an array? (these three options are the same)--------
        //int[] myScores = new int[5] { 100, 76, 88, 100, 90 };  //most formal

        //If you initialize an array with values, you are not required to give the array a size         
        //int[] myScores = new int[] { 100, 76, 88, 100, 90 };

        //If you initialize an array, you do not need to use the keyword new (recommended!)
        int[] myScores = { 100, 76, 88, 100, 90 };  //this is recommended!

        ///--------3. How to access an array?--------

        ////Print out a specific value with a position (EX1)
        Write("Enter position (starting with 0) >> ");
        int pos = Convert.ToInt32(ReadLine());
        WriteLine("Number in position {0} is {1}", pos, myScores[pos]);

        //Use a for loop
        //For example, everyone gets a 3 bonus points
        int sub = 0;
        while (sub < 5)
        {
            myScores[sub] += 3;
            ++sub;
        }

        //Or use a for loop (this is recommended!)
        //How about 5 more bonus points? ;)
        for (int i = 0; i < 5; ++i)
        {
            myScores[i] += 5;
        }

        //--------4. How to use the length property of an array?--------
        //For example, print out ALL from first to last.
        WriteLine("Array size is {0}", myScores.Length);
        for (int i = 0; i < myScores.Length; ++i)
        {
            WriteLine(myScores[i]);
        }

        //How about reverse the print order, from last to first? Decrement the counter
        //consider a reverse order for your challenge project.
        for (int i = myScores.Length - 1; i >= 0; --i)
        {
            WriteLine(myScores[i]);
        }

    }
}
