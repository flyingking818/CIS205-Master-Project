using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel.Design;
class Admission
{
 
    static void Main()
    {
        // Write your code here

       

        double gpa;
        int testScore;

        //Input
        Write("Please enter grade point average (GPA): ");
        gpa = Convert.ToDouble(ReadLine());

        Write("Please enter test score: ");
        testScore = Convert.ToInt32(ReadLine());

        /*
        //Processing 
        //Option 1: Nested IFs.
        if (gpa >= MIN_GPA)
            if (testScore >= ADMIN1)
                WriteLine("Accept");
            else
                WriteLine("Reject");
        else
            if (testScore >= ADMIN2)
                WriteLine("Accept");
            else
                WriteLine("Reject");

        //Option 2: Use the logical operations, such && ||

        //hint: put these into a black box and ask users to supply the inputs! :)
        //return the verdict!
        */

        string result = EvaluateStudent(gpa, testScore);

        WriteLine(result);



    }


    public static string EvaluateStudent(double gpa, int testScore)
    {
        const double MIN_GPA = 3.0;
        const int ADMIN1 = 60, ADMIN2 = 80;
        string verdict ="";

        if ((gpa >= MIN_GPA && testScore >= ADMIN1) || (gpa < MIN_GPA && testScore >= ADMIN2))
        {
            verdict = "Accept";
        }
        else
        {
            verdict = "Reject";
        }

        return verdict;
    }
}