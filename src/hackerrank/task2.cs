// https://www.hackerrank.com/challenges/simple-array-sum/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /
      Complete the 'staircase' function below.
     
      The function accepts INTEGER n as parameter.
     /

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
