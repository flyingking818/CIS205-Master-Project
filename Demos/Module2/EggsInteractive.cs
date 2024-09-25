using System;
using static System.Console;

namespace CIS205_Master_Project.Demos.Module2
{
    internal class EggsInteractive
    {
        static void Main()
        {
            //C# is case-sensitive, lowercase is different from uppercase variables
            //===Declaration===
            const int DOZENS = 12;

            //D&A process (LEAST rule) 
            //int chicken1 = 30, chicken2 = 20, chicken3 = 40, chicken4 = 25;
            int chicken1, chicken2, chicken3, chicken4;
            int total;
            int dozens, leftOver;

            //===Input procedure===
            Write("Please enter the number of eggs for chicken 1 (e.g., 20): ");
            //chicken1 = Convert.ToInt32(ReadLine());
            chicken1 = int.Parse(ReadLine());

            Write("and chicken 2 (e.g., 20): ");            
            chicken2 = int.Parse(ReadLine());

            Write("and chicken 3 (e.g., 20): ");
            chicken3 = int.Parse(ReadLine());

            Write("and chicken 4 (e.g., 20): ");
            chicken4 = int.Parse(ReadLine());

            //===Processing===
            //Sub1
            total = chicken1+chicken2+chicken3+chicken4;

            //Sub2 - integer divsion rule: the fractional part will be discarded.
            dozens = total / DOZENS;
            //dozens = (int)total / DOZENS;

            //Sub3 - use the modulus 
            leftOver = total % DOZENS;

            //====Output=====
            //1) Placeholders
            WriteLine("{0} eggs is {1} dozens and {2} eggs.", total,dozens,leftOver);

            //2) Interplolation using $
            WriteLine($"{total} eggs is {dozens} dozens and {leftOver} eggs.");

            //3) string concatenation using +            
            WriteLine(total + " eggs is " + dozens + " dozens and " + leftOver + " eggs.");

        }
    }
}
