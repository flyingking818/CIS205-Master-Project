using System;
using static System.Console;

class Eggs
{
    static void Main()
    {
        //Declarations
        const int DOZENS = 12;
        //int chicken1 = 30, chicken2 = 20, chicken3 = 40, chicken4 = 25;
        int chicken1, chicken2, chicken3, chicken4; 
        int total;
        int dozens, leftOver;

        //Input
        Write("Please enter the number of eggs for chicken 1: ");
        chicken1 = int.Parse(ReadLine());
        Write("And for chicken 2: ");
        chicken2 = Convert.ToInt32(ReadLine());
        Write("And for chicken 3: ");
        chicken3 = Convert.ToInt32(ReadLine());
        Write("And for chicken 4: ");
        chicken4 = Convert.ToInt32(ReadLine());

        //Processing
        total = chicken1 + chicken2 + chicken3 + chicken4;
        dozens = total / DOZENS;
        leftOver = total % DOZENS;

        //Output
        WriteLine("A total of {0} eggs is {1} dozen and {2} eggs.", total,dozens,leftOver);

        WriteLine($"A total of {total} eggs is {dozens} dozen and {leftOver} eggs.");

        WriteLine("A total of "+ total + " eggs is " + dozens + " dozen and "+leftOver+" eggs.");



    }
}

