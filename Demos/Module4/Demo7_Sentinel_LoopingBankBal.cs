/* 
 Calculate bank balance based on compound interest rate. 

p = p*(1+i)^n
p = p*(1+i)(1+i)...(1+i)

Pay attention to the sentinel value.
Compare the while loop and do...while loop. 
 */


using System;
using static System.Console;
class LoopingBankBal
{
    static void Main()
    {
        const double INT_RATE = 0.04;

        double bankBal;
        char response;  //sentinel variable - flag  - char requires single quotes!!!

        Write("Please enter your bank balance: ");
        bankBal = Convert.ToDouble(ReadLine());

        Write("Do you want to see your balance? Y or N... ");
        response = Convert.ToChar(ReadLine());

        char.ToUpper(response)

        /*
         * 
       
        while (response=='Y' || response == 'y')   // || means OR, && means AND, ! means NOT
        {
            WriteLine("Bank balance is {0}", bankBal.ToString("C"));
            bankBal = bankBal + bankBal * INT_RATE;
            Write("Do you want to see next year's balance? Y or N...");
            response = Convert.ToChar(ReadLine());
        }
        */

        //Do...While loop => execute at least once (avoid this if you can). we usually use this for 
        //recordset processing.

       
        do
        {
            WriteLine("Bank balance is {0}", bankBal.ToString("C"));
            bankBal = bankBal + bankBal * INT_RATE;
            Write("Do you want to see next year's balance? Y or N...");            
            response = Convert.ToChar(ReadLine());
        } while (response == 'Y' || response == 'y');
      

    }
}