/*
Business rules:
Give movie discount to chidren under 12 and senior at least 65 for the G-rated movies.

Use AND (&&) and OR (||) logical operators  () 
Pay attention to the execution rules
 */

using System;
using static System.Console;
class MovieDiscount
{
    static void Main()
    {
        const int CHILD_AGE = 12;
        const int SENIOR_AGE = 65;

        int age;
        char rating; //single character enclosed in ''

        Write("Please enter the age (e.g., 18): ");
        age = Convert.ToInt32(ReadLine());

        Write("Please enter movie rating (e.g., R or G): ");
        rating = Convert.ToChar(ReadLine());

        //compound decision making (be careful with the logic!)
        //Test each condition individually first, then combine!!!!
        if ((age < CHILD_AGE || age >= SENIOR_AGE) && rating == 'G') {
            WriteLine("Discount applied!");
        }
        else
        {
            WriteLine("Full price, sorry!:(");
        }

        if ((age >= CHILD_AGE && age < SENIOR_AGE) || rating == 'R')
            WriteLine("Full Price");
        else
            WriteLine("Discount applies!");

        if (((age >= CHILD_AGE && age < SENIOR_AGE) || rating == 'R') != true)
            WriteLine("Discount applies!");
        else
            WriteLine("Full Price");








    }
}
