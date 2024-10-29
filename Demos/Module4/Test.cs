using System;
using static System.Console;
using System.Globalization;
class SumInts
{
    static void Main()
    {
        //Declarations
        const int LIMIT = 999;
        int num, sum = 0;

        //==================Loop Structure=============
        //Input
        int i = 0;
        while (i != LIMIT)
        {
            Write("Please enter an integer: ");
            num = Convert.ToInt32(ReadLine());
            sum += num;
            i++;    //i = i + i;
        }
        WriteLine($"The total is (sum).");
    }
}
