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
        double inches;
        double measurementInCM;
        //double inches = 3;

        //Let's make it interactive
        Write("Please enter the measurement in inches: ");
        inches = Convert.ToDouble(ReadLine());


        //Processing

        measurementInCM = inches * CENTIMETER_PER_INCH;

        //Output
        WriteLine("{0} inches is {1} centimeters.", inches, measurementInCM);

        //string concatenation with +
        WriteLine(inches + " inches is " + measurementInCM + " centimeters.");

        //Interpolation
        WriteLine($"{inches} is {measurementInCM} centimeters.");

    }
}