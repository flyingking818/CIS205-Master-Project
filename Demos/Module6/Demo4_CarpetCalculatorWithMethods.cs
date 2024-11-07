using System;
using static System.Console;

namespace CarpetCalculatorWithMethods
{
    class CarpetCalculator
    {
        //Declare global constants
        const int SQFT_TO_SQYARD = 9;
        const int INCHES_PER_FOOT = 12;

        static void Main(string[] args)
        {
            double roomLength,
                    roomWidth,
                    roomAreaInSquareYard,
                    carpetUnitPrice;

            //1. Display instructions to users (void)
            DisplayInstructions();

            //2. Get room dimensions (double)
            roomLength = GetRoomSize("Room Length");
            roomWidth = GetRoomSize("Room Width");

            //3. Get room area in square yards (double)
            roomAreaInSquareYard = CalculateRoomAreaInSquareYards(roomLength, roomWidth);

            //4. Get the carpet unit price (double)
            carpetUnitPrice = GetCarpetUnitPrice();


            //5. Display results (=>5.1 Calculate Carpet Cost(double)) (void)
            DisplayResults(roomAreaInSquareYard, carpetUnitPrice);


        }

        static void DisplayInstructions()
        {
            Clear();
            WriteLine("{0,30}", "Carpet Calculator with Methods!");
            WriteLine();
            WriteLine("This program calculates the area and cost of" +
                        " carpet to be purchased!");
            WriteLine("Please enter the dimensions of the room and the price of the carpet" +
                " price per square yard!");
        }

        static double GetRoomSize(string roomSide)
        {
            string inputValue;
            int feet,
                inches;

            WriteLine("Please enter the {0} in Feet: ", roomSide);
            inputValue = ReadLine();

            int numberSide;
            //The TryParse is a good method for data validation! :)
            while (!int.TryParse(inputValue, out numberSide))
            {
                WriteLine("Please enter a numeric value!!!!");
                inputValue = ReadLine();
            }

            feet = numberSide;

            WriteLine("Please enter the {0} in Inches: ", roomSide);
            inputValue = ReadLine();

            while (!int.TryParse(inputValue, out numberSide))
            {
                WriteLine("Please enter a numeric value!!!!");
                inputValue = ReadLine();
            }
            inches = numberSide;

            return (feet + (double)inches / INCHES_PER_FOOT);

        }

        static double CalculateRoomAreaInSquareYards(double length, double width)
        {
            double squareYards;
            squareYards = length * width / SQFT_TO_SQYARD;
            return squareYards;
        }

        static double GetCarpetUnitPrice()
        {
            string userInput;
            WriteLine("Please enter the carpet unit price per square yard:");
            userInput = ReadLine();

            double numberUnitPrice;
            while (!double.TryParse(userInput, out numberUnitPrice))
            {
                WriteLine("Please enter a numeric value!!!!");
                userInput = ReadLine();
            }
                        
            return (numberUnitPrice);
        }

        static void DisplayResults(double roomArea, double unitPrice)
        {
            Clear();
            WriteLine("Square Yards Needed: {0:N2}", roomArea);
            WriteLine("Carpet Unit Cost: {0:C}", unitPrice);
            WriteLine("Total cost of carpet: {0:C}", DetermineCarpetCost(roomArea, unitPrice));
            ReadKey();

        }

        static double DetermineCarpetCost(double areaInSquareYards, double unitCostPerSquareYard)
        {
            return (areaInSquareYards * unitCostPerSquareYard);
        }

    }
}
