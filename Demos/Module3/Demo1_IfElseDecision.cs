/*
    Compare an input value with a threshold 
    Pay attention to indentation vs. curly brackets. 


*/

using System;
using static System.Console;

class IfElseDecision
{
    static void Main()
    {
        const int HIGH = 10;

        int number;

        //Input 
        Write("Please enter a number (e.g., 8): ");
        number = Convert.ToInt32(ReadLine());

        //Processing & Output

        /*
        Commmon comparison symbols are:
        Less than (<)
        Greater than (>)
        Equal to (==)
        Less than or equal to (<=)
        Greater than or equal to (>=)
        Not equal to (!=)

        */

        if (number > HIGH)
            WriteLine("{0} is greater than {1}", number, HIGH);
        else
            WriteLine("{0} is NOT greater than {1}", number, HIGH);

    }
}