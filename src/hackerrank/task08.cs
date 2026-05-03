// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{


    public static int migratoryBirds(List<int> arr)
    {
         int[] freq = new int[6]; 

        foreach (int bird in arr)
        {
             freq[bird]++;
        }
        int maxFreq = 0;
        int result = 0;
         for (int i = 1; i <= 5; i++)
         {
             if (freq[i] > maxFreq)
             {
                 maxFreq = freq[i];
                result = i;
             }
         }
          return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
