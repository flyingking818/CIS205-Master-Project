/*
 Carpet Calculator App
 Purpose: To calculate the total carpet cost based on a room's dimensions and 
          the selected carpet's unit price.
 Created By: Your Name Here
 Last Updated on: xx/xx/xxxx

 Tasks: 
    Rewrite the program using methods.
    1) How many methods could we possibly use?
    2) How could we validate user inputs?
*/

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class CarpetCalcultor
    {
        static void Main(string[] args)
        {
            //1. Declare constants
            const int SQFT_TO_SQYARD = 9;
            const int INCHES_PER_FOOT= 12;

            const string BEST_CARPET = "Berber";
            const string ECONOMY_CARPET = "Pile";

            //2. Declare variables
            int roomLengthFeet = 12;
            int roomLenghInches = 2;
            int roomWidthFeet = 14;
            int roomWidthInches = 7;

            double roomLength,
                   roomWidth,
                   roomAreaInSquareFeet,
                   roomAreaInSquareYard, 
                   carpetUnitPrice,
                   carpetTotalCost;

            //3. Calculate the unknown variables
            //3.1 Calculate Room Length and Width in FEET
            roomLength = roomLengthFeet + (double) roomLenghInches / INCHES_PER_FOOT;
            roomWidth = roomWidthFeet + (double)roomWidthInches / INCHES_PER_FOOT;

            //3.2 Calculate Area 
            roomAreaInSquareFeet = roomLength * roomWidth;
            roomAreaInSquareYard = roomAreaInSquareFeet / SQFT_TO_SQYARD;

            //3.3 Calculate Total Cost for Berber
            carpetUnitPrice = 27.95;
            carpetTotalCost = carpetUnitPrice * roomAreaInSquareYard;

            //4. Display the output for Berber
            WriteLine("{0,14}","Carpet App");
            WriteLine();
            WriteLine("{0,-7}{1,12:C}", BEST_CARPET+":", carpetTotalCost);

            //5. Repeat the calculation for pile            
            //5.1 Calculate Total Cost for Pile
            carpetUnitPrice = 15.95;
            carpetTotalCost = carpetUnitPrice * roomAreaInSquareYard;

            //5.2. Display the output for Pile
           
            WriteLine();
            WriteLine("{0,-7}{1,12:C}", ECONOMY_CARPET + ":", carpetTotalCost);
            ReadKey();               

        }
    }
}
