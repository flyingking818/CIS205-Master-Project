/* 
Write an application named OddNums that displays all the odd numbers from 1 through 99.
Display 10 numbers for each line.

Pay attention to the while loop with a control variable.


    *   *   *   *   *   *   *   *   *   *
    *   *   *   *   *   *   *   *   *   *
    *   *   *   *   *   *   *   *   *   *
    *   *   *   *   *   *   *   *   *   *
 */


using System;
using static System.Console;
class OddNums
{
   static void Main()
   {
        const int LIM = 99;
        const int END_OF_LINE = 10;

        int num = 1;
        int count = 1;

        while (num <= LIM)
        {
            Write("{0, 6}", num);
            if (count == END_OF_LINE) //reset the output line (not a loop)
            {
                WriteLine();
                count = 0;
            }

            num += 2;  //shorthand form for num = num + 2
            ++count;   //This is the counter management, shorthand form for count = count +1

            /*   
            In Pre-Increment, the operator sign (++) comes before the variable. 
            It increments the value of a variable before assigning it to another variable. 

            In Post-Increment, the operator sign (++) comes after the variable. 
            It assigns the value of a variable to another variable and then increments its value.
            */

           
            
            int a = 0;
            int b = ++a; // b = 1; a = 1
        
            /*
            int a = 0;
            int b = a++; // b = 0; a = 1
            */
       


        }

}

}
