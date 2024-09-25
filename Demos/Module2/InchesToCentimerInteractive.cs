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
        double inches;
        double measurementInCM;

        //implement the IPO programming paradigm (input-processing-output)

        //Input procedure (in console, we use prompts sequentially)
        Write("Please enter the length in inches (e.g., 3.0): ");
        //ReadLine() only return string value.
        inches = Convert.ToDouble(ReadLine());

        //Processing
        measurementInCM = inches * CENTIMETER_PER_INCH;

        //Output

        //1) Placeholders using index numbers starting from 0
        WriteLine("{0} inches is {1} centimeters.", inches, measurementInCM);

        //2) Interpolation using $ and variable name in {}
        WriteLine($"{inches} inches is {measurementInCM} centimeters.");

        //3) String concatenation using +
        WriteLine(inches + " inches is " + measurementInCM + " centimeters.");

    }
}