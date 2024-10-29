using System;
using static System.Console;
class AdvancedArrays
{

    static void Main()
    {
        //=============Parallel Arrays and Search Techniques================

        //1. Paralles arrays delcaration and intialization
        int[] validValues = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
        double[] prices = { 0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00 };

        int itemOrdered;
        double itemPrice = 0;
        bool isValidItem = false;

        Write("Please enter an item ");
        itemOrdered = Convert.ToInt32(ReadLine());

        //2. ------------For Loop Search Techniques-----------------
        //This would loop through ALL items => inefficient.
        for (int x = 0; x < validValues.Length; ++x)
        {
            if (itemOrdered == validValues[x]) // this is pretty picky!!!
            {
                isValidItem = true;
                itemPrice = prices[x];
            }
        }

        //Early exit. Some programmers might not like this, though.
        for (int x = 0; x < validValues.Length; ++x)
        {
            if (itemOrdered == validValues[x])
            {
                isValidItem = true;
                itemPrice = prices[x];
                //change x to .Length to force an early exit when a match is found!
                break;
                //x = validValues.Length;
            }
        }


        //Change the comparison to a compound statement, incorporating the isValidItem (or isFound) bool value.
        for (int x = 0; x < validValues.Length && !isValidItem; ++x)
        {
            if (itemOrdered == validValues[x])
            {
                isValidItem = true;
                itemPrice = prices[x];
            }
        }


        //3. ------------While Loop Search Techniques-----------------
        int i = 0;
        //Keep searching with the array range until there is a match.
        while (i < validValues.Length & itemOrdered != validValues[i])
        {
            ++i;
        }
        if (i != validValues.Length)
        {   //This means there's a match, as i is found before it goes outside the array.
            isValidItem = true;
            itemPrice = prices[i];
        }

        if (isValidItem)
            WriteLine("Price is {0}", itemPrice);
        else
            WriteLine("Sorry, item not found");


        /*
         Multi- dimensional array. 
         In a rectangular array, each row has the same number of columns.Think of this as a table.
        */
        int[,] rents = {
            {400, 500, 510 },
            {500, 560, 630 },
            {625, 676, 740 },
            {10000, 1250, 1600 }
        };

        int floor;
        int bedrooms;
        string inputString;

        WriteLine("Enter the floor on which you want to live");
        inputString = ReadLine();
        floor = Convert.ToInt32(ReadLine());
        WriteLine("Enter the number of rooms you need");
        inputString = ReadLine();
        bedrooms = Convert.ToInt32(ReadLine());

        WriteLine("The rent is {0}", rents[floor, bedrooms]);

        //Here's another example of rectangular array 3x4
        double[,] sales = {
            {14.00, 15.00, 16.00, 17.00},
            {21.99, 34.55, 67.88, 31.99},
            {12.03, 55.55, 32.89, 1.17}
        };

        /*
        Jagged arrays - a one-dimensional array in which each element is another array.
        The major difference between jagged and rectangular arrays is that in jagged arrays,
        each row can be a different length.

        In the following example, two square brackets are used to declare a jagged array
        that is composed of five separate one-dimensional arrays. Metro routes with different stops.

        Note: For a jagged array, each row needs its own new operator and data type. 
        e.g., tickets[0][1] = 6.75, how about tickets[1][2]??
        */
        double[][] tickets = {
            new double[] {5.50, 6.75, 7.95, 9.00, 12.00,13.00, 14.50, 17.00, 19.00, 20.25},
            new double[] {5.00, 6.00 },
            new double[] {7.50, 9.00, 9.95, 12.00, 13.00, 14.00 },
            new double[] {3.50, 6.45, 9.95, 10.00, 12.75 },
            new double[] {15.00, 16.00 }
        };


        //jagged array with different data types
        object[] diffTickets = new object[5];
        diffTickets[0] = new double[] { 5.50, 6.75, 7.95, 9.00, 12.00, 13.00, 14.50, 17.00, 19.00, 20.25 };
        diffTickets[1] = new int[] { 5, 6 };
        diffTickets[2] = new decimal[] { 7.50M, 9.00M, 9.95M, 12.00M, 13.00M, 14.00M };
        diffTickets[3] = new float[] { 3.50f, 6.45f, 9.95f, 10.00f, 12.75f };
        diffTickets[4] = new string[] { "$15.00", "$16.00" };

    }
}
