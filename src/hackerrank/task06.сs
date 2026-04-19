// https://www.hackerrank.com/challenges/kangaroo/problem
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

    

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;
        int maxA = a.Max();
        int minB = b.Min();

        for (int x = maxA; x <= minB; x++)
        {
            bool valid = true;
            foreach (int val in a)
            {
                if (x % val != 0)
                {
                    valid = false;
                    break;
                }
            }

            if (!valid) continue;

          
            foreach (int val in b)
            {
                if (val % x != 0)
                {
                    valid = false;
                    break;
                }
            }

            if (valid) count++;
        }

        return count;
    }

    }



class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
