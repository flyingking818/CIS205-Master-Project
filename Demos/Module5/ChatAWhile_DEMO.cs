using System;
using static System.Console;
using System.Globalization;
class ChatAWhile_DEMO
{
    static void Main()
    {
        string[] area = {  "414", "262", "608", "715", "815", "920" };
        double[] price = {  0.10, 0.07, 0.05, 0.16, 0.24, 0.14 };

        
        int i, minutes;
        double total = 0;
        string entryArea;
        bool isFound = false;

        Write("What area code are you calling? ");
        entryArea = ReadLine();

        for (i = 0; i < area.Length && !isFound; ++i)
        {
            if (entryArea == area[i])
            {
                Write("How many minutes is your call? ");               
                minutes = Convert.ToInt32(ReadLine());
                total = price[i] * minutes;
                WriteLine($"Your phone call to area {entryArea} costs {price[i].ToString("C", CultureInfo.GetCultureInfo("en-US"))} per minute");
                WriteLine($"For {minutes} minutes the total is {total.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");                   
                isFound = true;
            }
        }
        if (!isFound)
            WriteLine($"Sorry - no calls allowed to area {entryArea}");
        

        /*

        //=================Using Array Methods==============
        // Sort the area and price arrays in parallel
        Array.Sort(area, price);

        Write("What area code are you calling? ");
        string entryArea = ReadLine();
        int index = Array.BinarySearch(area, entryArea);

        if (index >= 0) // Found a matching area code
        {
            Write("How many minutes is your call? ");
            int minutes = Convert.ToInt32(ReadLine());
            double total = price[index] * minutes;

            WriteLine($"Your phone call to area {entryArea} costs {price[index].ToString("C")} per minute");
            WriteLine($"For {minutes} minutes the total is {total.ToString("C")}");
        }
        else // No matching area code
        {
            WriteLine($"Sorry - no calls allowed to area {entryArea}");
        }

        */

    }
}