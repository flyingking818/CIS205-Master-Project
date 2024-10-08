/*
 Evaluate users based on age. 
1-8
9-15
16-100
101 or above 

Pay speecial attention to the conditional "case when" statements, 
which is new since C#7.0
 */


using System;
using static System.Console;
class SwitchWhenDemo
{
    static void Main()
    {
        int age;
        Write("Enter your age >> ");
        age = Convert.ToInt32(ReadLine());

        switch (age)
        {
            case int i when i >= 1 && i <= 8:
                WriteLine("You are only " + age + " years old. You must be kidding right? Please fill in your *real* age.");
                break;
            case int i when i >= 9 && i <= 15:
               WriteLine("You are only " + age + " years old. That's too young!");
                break;
            case int i when i >= 16 && i <= 100:
                WriteLine("You are " + age + " years old. Perfect.");
                break;
            default:
                WriteLine("You are an old person.");
                break;
        }


        //Huricane Option 3
        const int CAT1 = 74;
        const int CAT2 = 96;
        const int CAT3 = 111;
        const int CAT4 = 130;
        const int CAT5 = 157;


        int windSpeed;
        Write("Enter your wind speed: ");
        windSpeed = Convert.ToInt32(ReadLine());

        switch (windSpeed)
        {
            case int i when i >= CAT5:
                WriteLine("Category 5!");
                break;
            case int i when i >= CAT4 && i<CAT5:
                WriteLine("Category 4!");
                break;
            case int i when i >= CAT3 && i<CAT4:
                WriteLine("Category 3!");
                break;
            case int i when i >= CAT2 && i<CAT3:
                WriteLine("Category 2!");
                break;
            case int i when i >= CAT1 && i<CAT2:
                WriteLine("Category 1!");
                break;
            default:
                WriteLine("This is not a hurricane.");
                break;
        }
    }
}
