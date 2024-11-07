/* 
 Implementation hiding
    1) An important principle of object-oriented programming
    2) Keeps the details of a method’s operations hidden

    The only concern is the way you interface, or interact, with the method
    1) The program does not need to know how the method works
    2) A method that uses another is a client of that method
    3) Methods exist in a black box – a virtual device you can use without knowing 
    how it works internally
 */

using static System.Console;

class MethodBasics
{
    static void Main()
    {
        //The bloat problem - Unnecessarily long or repetitive statements

        /*
        WriteLine("Welcome. ");
        WriteLine("Have fun! ");
        WriteLine("Enjoy the program! ");
        */


        ShowMessage();
               
        WriteLine("Let's do it again! :)");

        ShowMessage();

        //Demo 2 - Local variables, which are variables local (scope) to its containing methods.
        // Global variables, on the other hand, are visible (hence accessible) throughout the program.
        int a = 12;
        WriteLine("In Main() a is {0}", a);

        MethodWithItsOwnA();
        WriteLine("In Main() a is {0}", a);

        //Demo 3 - Pass a single argument/value to methods
        // The terms argument and parameter are closely related.
        //An argument is data in a method call, and a parameter is in the method header

        DisplaySalesTax(1000.00);

    }
      
    //We usually put the custom methods after and outside the Main()
    static void ShowMessage()
    {
        WriteLine("Welcome. ");
        WriteLine("Have fun! ");
        WriteLine("Enjoy the program! ");
    }

    private static void MethodWithItsOwnA()
    {
        int a = 354;
        WriteLine("In method a is {0}", a);
    }

    private static void DisplaySalesTax(double saleAmount)  //parameter
    {
        double tax;
        const double RATE = 0.07;

        tax = saleAmount * RATE;
        WriteLine("The tax on {0} is {1}\n", saleAmount.ToString("C"), tax.ToString("C"));
        //don't do the display in a sub method! For other UI programs, the sub methods does not have
        //access to the UI layer. 

    }   

}

