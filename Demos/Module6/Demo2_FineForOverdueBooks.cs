/*
Create an application for a library and name it FineForOverdueBooks. The Main() method 
asks the user to input the number of books checked out and the number of days they are overdue.
Pass those values to a method that displays the library fine, which is 10 cents per book 
per day for the first seven days a book is overdue, then 20 cents per book per day for 
each additional day.
 */


using System;
using static System.Console;
using System.Globalization;
public class FineForOverdueBooks
{
    public static void Main()
    {
        int books;
        int days;
        Write("Enter number of books that are overdue >> ");
        books = Convert.ToInt32(ReadLine());
        Write("Enter number of days that the {0} books are overdue >> ", books);
        days = Convert.ToInt32(ReadLine());
        DisplayFine(books, days);
    }
    public static void DisplayFine(int books, int days)
    {
        const double FINE1 = 0.10;
        const double FINE2 = 0.20;
        const int DAY_FINE_INCREASES = 7;
        double fine;
        if (days <= DAY_FINE_INCREASES)
            fine = books * days * FINE1;
        else
            fine = books * FINE1 * DAY_FINE_INCREASES +
               books * FINE2 * (days - DAY_FINE_INCREASES);
        WriteLine("The fine for {0} book(s) for {1} day(s) is {2}",
           books, days, fine.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }


    /*===========Alternative Solution=================
   
    Create a method a calculate the fine and return it back to the Main(). Then display it in the main.

    public static void Main()
 {
    int books;
    int days;
    double bookFine;

    Write("Enter number of books that are overdue >> ");
    books = Convert.ToInt32(ReadLine());
    Write("Enter number of days that the {0} books are overdue >> ", books);
    days = Convert.ToInt32(ReadLine());

    bookFine = CalculateFine(books, days);

    WriteLine($"The fine for {books} book(s) for {days} day(s) is {bookFine.ToString("C")}.");        
  }
 public static double CalculateFine(int books, int days)
 {
    const double FINE1 = 0.10;
    const double FINE2 = 0.20;
    const int DAY_FINE_INCREASES = 7;
    double fine;

    if(days <= DAY_FINE_INCREASES)
       fine = books * days * FINE1;
    else 
       fine = books * FINE1 * DAY_FINE_INCREASES + books * FINE2 * (days - DAY_FINE_INCREASES);

    return fine;
 }
    */




}


