/*
Suppose you want to display future bank balances for different years at a variety of 
interest rates. For example, the application displays annually compounded interest on 
$1000 at 4 percent, 6 percent, and 8 percent interest rates for one through five years.

Pay attention to the nested looping structure.
*/

using static System.Console;
class LoopingBankBal2
{
    static void Main()
    {        
        const double START_BAL = 1000;
        const double START_INT = 0.04;
        const double INT_INCREASE = 0.02; //step value
        const double LAST_INT = 0.08;
        const int END_YEAR = 5;

        double bankBal;
        double rate;
        int year;

        
        for (rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE) //outer loop
        {
            bankBal = START_BAL;
            WriteLine("Starting bank balance is {0}", bankBal.ToString("C"));
            WriteLine("Interest Rate: {0}", rate.ToString("P"));
            for (year = 1; year <= END_YEAR; ++year) //inner loop
            {
                bankBal = bankBal + bankBal * rate; //bankBal = bankBal * (1 + rate);
                WriteLine(" After year {0}, bank balance is {1}", year, bankBal.ToString("C"));
            }
            WriteLine();
        }
    }
}