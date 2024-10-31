/*
    Write a program named TestScoreList that accepts eight int values representing student test scores. 
    Display each of the values along with a message that indicates how far it is from the average. 
 */



using System;
using static System.Console;
class TestScoreList
{
    static void Main()
    {
        int[] scores = new int[8];
        int testNum;
        double total = 0;
        double avg;

        for (testNum = 0; testNum < scores.Length; ++testNum)
        {
            Write("Please enter score for test number {0} >> ", (testNum + 1));
            scores[testNum] = Convert.ToInt32(ReadLine());
            total += scores[testNum];
        }
        avg = total / scores.Length;

        WriteLine("Scores for the tests are:");
        for (testNum = 0; testNum < scores.Length; ++testNum) 
        { 
            WriteLine("Test # {0}: {1, 5} From average: {2, 5}", testNum,
              scores[testNum].ToString(), (scores[testNum] - avg).ToString());
        }
        WriteLine("\n  Total is {0, 5}", total.ToString());
        WriteLine("Average is {0, 5}", avg.ToString());
    }
}
