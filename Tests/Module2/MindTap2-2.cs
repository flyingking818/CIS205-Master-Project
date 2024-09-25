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

        double numberOfInches = 3;

        //Processing

        double centimeters = numberOfInches * CENTIMETER_PER_INCH;

        //Output
        WriteLine("{0} inches is {1} centimeters.", numberOfInches, centimeters);


    }
}