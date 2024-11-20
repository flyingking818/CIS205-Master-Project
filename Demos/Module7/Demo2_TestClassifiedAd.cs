/*
1) Create an application named TestClassifiedAd that instantiates and displays at least two ClassifiedAd objects. 
2) A ClassifiedAd has fields for a category (for example, Used Cars), a number of words, and a price. 
3) Include properties that contain get and set accessors for the category and number of words, but only a 
    get accessor for the price. 
4) The price is calculated at nine cents per word.
 */

using static System.Console;
using System.Globalization;
public class TestClassifiedAd
{
   public static void Main()
   {
      ClassifiedAd myClassifiedAd = new ClassifiedAd();
      ClassifiedAd yourClassifiedAd = new ClassifiedAd();
      myClassifiedAd.Category = "Used cars";
      myClassifiedAd.Words = 100;
      yourClassifiedAd.Category = "Help wanted";
      yourClassifiedAd.Words = 60;
      WriteLine("The classified ad with {0} words in category {1} costs {2}", myClassifiedAd.Words,
          myClassifiedAd.Category, myClassifiedAd.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("The classified ad with {0} words in category {1} costs {2}", yourClassifiedAd.Words,
          yourClassifiedAd.Category, yourClassifiedAd.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}
class ClassifiedAd
{
   
   const double PRICE_PER_WORD = 0.09;
   public int words;
   public double price;
   public string Category {get;set;}

   public int Words 
        //The Words property has special business rules. Therefore, the instance variables are required.
   {
     get
     {
        return words;
     }
     set
     {
        words = value;
        price = words * PRICE_PER_WORD; //price instance variable is calcuated in the Words setter!
     }
   }
   public double Price
   {
      get
      {
         return price;
      }
   }
}