// https://www.hackerrank.com/challenges/between-two-sets/problem
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



    public static List<int> breakingRecords(List<int> scores)
    {
        int best = scores[0];
        int worst = scores[0];
        int bestCount = 0;
        int worstCount = 0;
        
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > best)
            {
                best = scores[i];
                bestCount++;
                
            }
            else if (scores [i] < worst)
            {
                worst = scores[i];
                worstCount++;
            }
        }
        
        return new List<int> { bestCount, worstCount };

    }

}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
