/*
Business rules:
Give discounts based on different states. For Flagler College students, 
special discount is available.
 
Pay special attention to the nested if in switch statements.

Development ideas:
Factor: State
>>>>Factor: isFlagler

Switch (State)

 */


using System;
using static System.Console;
using System.Globalization;
class StateDiscount
{
    static void Main()
    {
        double purchasePrice;
        string stateCode;
        double discountState;
        double salePrice;
        bool isFlaglerStudent;

        Write("Enter your purchase price >> ");
        purchasePrice = double.Parse(ReadLine());

        Write("Enter your state code (e.g., FL) >> ");
        stateCode = ReadLine();

        Write("Are you a Flagler Student? (e.g., True or False) >> ");
        isFlaglerStudent = Convert.ToBoolean(ReadLine());

        switch (stateCode)
        {

            case "FL":
                if (isFlaglerStudent)
                {
                    discountState = 0.15;
                }
                else
                {
                    discountState = 0.10;
                }
                break;
            case "CO":  //this is the "OR" logic
            case "GA":
                discountState = 0.08;
                break;
            case "MI":
                discountState = 0.05;
                break;
            case "NY":
                discountState = 0.03;
                break;
            default:
                discountState = 0;
                break;
        }

        salePrice = purchasePrice * (1 - discountState);

        WriteLine("Your state discount is {0} and your final sale price is {1}.",
            discountState.ToString("P"),
            salePrice.ToString("C", CultureInfo.GetCultureInfo("en-US"))
            );

    }
}


