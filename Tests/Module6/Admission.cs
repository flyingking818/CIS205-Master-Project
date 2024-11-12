using System;
using static System.Console;
class Admission
{
    static void Main()
    {       
        const double MINGPA = 3.0;
        const int ADMIN1 = 60, ADMIN2 = 80;

        double gpa;
        int testScore;

        Write("Enter grade point average: ");
        gpa = Convert.ToDouble(ReadLine());
        Write("Enter test score: ");
        testScore = Convert.ToInt32(ReadLine());

        //Nested IFs
        if (gpa >= MINGPA)
            if (testScore >= ADMIN1)
                WriteLine("Accept");
            else
                WriteLine("Reject");
        else
            if (testScore >= ADMIN2)
                WriteLine("Accept");
            else
                WriteLine("Reject");

        //Alternative - logical operators &&, ||     

        if ((gpa >= MINGPA && testScore >= ADMIN1) || (gpa < MINGPA && testScore >= ADMIN2))
            WriteLine("Accept");
        else
            WriteLine("Reject");

    }
}
