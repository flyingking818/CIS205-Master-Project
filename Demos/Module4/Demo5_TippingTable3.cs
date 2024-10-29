using System;
using static System.Console;
using System.Globalization;
class TippingTable3
{
    static void Main()
    {
        const double STEP = 0.05;
        const double DINNERSTEP = 10.00;
        const int FIELDSIZE = 8;

        double dinnerPrice;
        double tipRate;
        double tip;
        double highRate;
        double lowRate;
        double highDinner;
        double lowDinner;

        Write("Enter lowest tip rate ");
        lowRate = Convert.ToDouble(ReadLine());

        Write("Enter highest tip rate ");
        highRate = Convert.ToDouble(ReadLine());

        Write("Enter lowest dinner value ");
        lowDinner = Convert.ToDouble(ReadLine());

        Write("Enter highest dinner value ");
        highDinner = Convert.ToDouble(ReadLine());

        Write("   Price");
        for (tipRate = lowRate; tipRate <= highRate; tipRate += STEP)
            Write("{0, 8}", tipRate.ToString("F"));
        WriteLine();
        for (int count = 0; count < 10 + FIELDSIZE * ((highRate - lowRate) / STEP + 1); ++count)
            Write("-");
        WriteLine();

        tipRate = lowRate;
        dinnerPrice = lowDinner;
        while (dinnerPrice <= highDinner)  //Nested loop to generate a two-variable table.
        {
            Write("{0, 8}", dinnerPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            while (tipRate <= highRate)
            {
                tip = dinnerPrice * tipRate;
                Write("{0, 8}", tip.ToString("F"));
                tipRate += STEP;
            }
            dinnerPrice += DINNERSTEP;
            tipRate = lowRate;
            WriteLine();
        }
    }
}