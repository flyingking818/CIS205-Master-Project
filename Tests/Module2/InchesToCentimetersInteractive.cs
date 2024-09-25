using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
    static void Main()
    {
        // Write your code here
        //Declarations
        const double CENTIMETER_PER_INCH = 2.54;
        //double inches = 3; //hard-coding
        double inches; //assign later via input
        double measurementInCM;

        //Input procedure
        Write("Please enter inches: ");
        inches = Convert.ToDouble(ReadLine());

        //Processing
        measurementInCM = inches * CENTIMETER_PER_INCH;

        //Output

        //Option 1: Placeholders
        WriteLine("{0} inches is {1} centimeters.", inches, measurementInCM);

        //Option 2: Interpolation using $
        WriteLine($"{inches} inches is {measurementInCM} centimeters.");

        //Option 3: Strig concatenation using + (common in ASP.NET)
        WriteLine(inches + " inches is " +  measurementInCM + " centimeters.");


    }
}