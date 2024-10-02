/* 
If the competition has more than twice as many contestants as last year, display 
    The competition is more than twice as big this year!

If the competition is bigger than last year’s but not more than twice as big, display 
    The competition is bigger than ever!

If the competition is smaller than last year’s, display, 
    A tighter race this year! Come out and cast your vote! 
 */


using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
    static void Main()
    {
        const int ENTRANCE_FEE = 25;
        string entryString;
        int numThisYear;
        int numLastYear;
        int revenue;

        Write("Enter number of contestants last year >> ");
        entryString = ReadLine();
        numLastYear = Convert.ToInt32(entryString);
        Write("Enter number of contestants this year >> ");
        entryString = ReadLine();
        numThisYear = Convert.ToInt32(entryString);

        revenue = numThisYear * ENTRANCE_FEE;

        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
           numLastYear, numThisYear);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        //More efficient use of the else if statement
        if (numThisYear > 2 * numLastYear)
            WriteLine("The competition is more than twice as big this year!");
        else if (numThisYear > numLastYear)
            WriteLine("The competition is bigger than ever!");
        else if (numThisYear < numLastYear)
            WriteLine("A tighter race this year! Come out and cast your vote!");
    }
}