/*
 Evaluate users based on age. 
1-8
9-15
16-100
101 or above 

Pay speecial attention to the conditional "case when" statements, which is new since C#7.0
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

    }
}
