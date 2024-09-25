using System;
using System.Globalization;
using static System.Console;

//------------------------------Code Analysis Assignment---------------------------------------
class GreenvilleRevenue
{
    static void Main()
    {
        //Avoid this. Only if you are working on system that requries precision that double can't handle.
        decimal ENTRANCE_FEE = 25m; //You MUST appendix the suffix "M/m" if you have decimal places.                                         
                                      //decimal decimalValue2 = 1.00;   //ERROR: Implicit conversion from double is NOT allowed.
                                      //decimal decimalValue3 = 1;     //OK: Implicit conversion from int is allowed, though.

        int numberLastYear, numberThisYear;
        double revenue;
        bool isThisYearGreater;

        //Input procedures
        Write("Please enter the number of contestants for last year: ");
        numberLastYear = Convert.ToInt32(ReadLine());
        Write("Please enter the number of contestants for this year: ");
        numberThisYear = Convert.ToInt32(ReadLine());

        //Processing
        //1) Sub-processing - calculate the revenue = P (c) *Q
        revenue = numberThisYear * Convert.ToDouble(ENTRANCE_FEE); //explicit conversion
                                                                   //revenue = numberThisYear * (double)ENTRANCE_FEE; //explicit casting example

        //2) Sub-processing - determine the isGreater bool
        /*
         Relational operators in C# are:
         Less than (<)
         Greater than (>)
         Equal to (==)
         Less than or equal to (<=)
         Greater than or equal to (>=)
         Not equal to (!=)
        */
        isThisYearGreater = numberThisYear > numberLastYear;

        //Output

        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
                numberLastYear, numberThisYear);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        //Short format form.
        WriteLine("Revenue expected this year is {0:C2}", revenue);

        WriteLine("It is {0} that this year's competition is bigger than last year's.", isThisYearGreater);



        //Alignment 
        //{0, -10} => first position, left alignmnent with 10 characters
        //{1, 30} => second position, right alignment with 30 characters
        //total = 10 + 30 = 40 characters

        WriteLine("{0, -10}{1, 30}", "Last Year: ", numberLastYear);
        WriteLine("{0, -10}{1, 30}", "This Year: ", numberThisYear);

        //Interpolation alternative
        WriteLine($"{"Last Year: ",-10}{numberLastYear,30}");
        WriteLine($"{"This Year: ",-10}{numberThisYear,30}");

        //=============Additional notes - double vs. decimal=================
        /*
           Decimal and double are two different numeric data types in C# with distinct characteristics. 
           They are used for different purposes depending on the requirements for precision and range. 
           Here's an example that illustrates the differences between decimal and double. 
            1) double is a binary floating-point type, and it is suitable for a wide range of values with good 
                precision but limited decimal accuracy.
            2) decimal is a high-precision decimal type that is suitable for financial calculations and other 
                scenarios where exact decimal representation is critical.

            Pay close attention to the significant digits of the follwoing results.
         */
        double doubleValue = 1.0 / 3.0;
        decimal decimalValue = 1.0m / 3.0m;

        WriteLine("Double Value: " + doubleValue);
        WriteLine("Decimal Value: " + decimalValue);

        // Perform calculations
        double doubleResult = doubleValue * 1000000000.0;
        decimal decimalResult = decimalValue * 1000000000.0m;

        WriteLine("Double Result: " + doubleResult);
        WriteLine("Decimal Result: " + decimalResult);

        //=========Data Type Precedence=================

        /*

        In C#, data types with higher precedence refer to those that have 
        a higher priority or influence over others when performing operations 
        or expressions involving multiple data types. 
        Here's a list of C# data types in descending order of precedence:

        1. Double Type (double) /Decimal type (decimal)
        2. Float Type (float)
        3. Long Type (long)
        4. Int Type (int)
        5. Short Type (short)
        6. Byte Type (byte)
        7. Char Type (char)

        In C#, when performing operations involving different data types, 
        the compiler promotes the operands to the data type with higher 
        precedence to ensure that precision and accuracy are maintained 
        in the result. For example, if you perform an operation between an int and a double, 
        the int will be promoted to a double before the operation is executed.\            
         */

        //Example 1:
        int intNum = 10;
        double doubleNum = 5.5;
        double result = intNum + doubleNum;

        WriteLine("Result: " + result); // Result: 15.5


        //Example 2:
        //No implicit casting between double and decimal, or float and decimal due to
        //range and precision differences. Need to use explicit conversions (e.g., cast)

        decimal decimalNum = 10.5M;
        decimal result2 = decimalNum + (decimal)doubleNum;

        WriteLine("Result: " + result2);

        float floatlNum = 13.5f;
        decimal result3 = decimalNum + (decimal)floatlNum;
        WriteLine("Result: " + result3);
    }
}
