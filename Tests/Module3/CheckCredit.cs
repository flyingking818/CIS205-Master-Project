/*
 Write a program named CheckCredit that prompts users to enter a purchase price for an item. 

 If the value entered is greater than a credit limit of $8,000, 
    display an error message; 
 otherwise, 
    display Approved. 
 */

using System;
using static System.Console;
class CheckCredit
{
    static void Main()
    {
        //This is an example of constraint
        const double LIMIT = 8000;  //a business rule which can change in the future.
        double price;

        Write("Enter price >> ");

        while (!double.TryParse(ReadLine(), out price))
        {
            Write("Please enter a valid price");
        }
        //price = Convert.ToDouble(ReadLine());


        //Translation examples of comparsion symbols

        // over >
        // under <
        // within <=
        // does not exceed <=

        // (hired) on or after >=
        // (hired) after >
        // (hired) before <
        // (hired) before or on <=


        if (price > LIMIT)
            WriteLine("You have exceeded the credit limit of ${0}", LIMIT);
        else
            WriteLine("Approved");
    }
}
