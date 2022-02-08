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

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var num = (double)arr.Count();

        var positive = new List<double>();
        var zeroes = new List<double>();
        var negative = new List<double>();

        foreach (var item in arr)
        {
            if (item > 0)
            {
                positive.Add((double)item);
            }
            else if (item == 0)
            {
                zeroes.Add((double)item);
            }
            else
            {
                negative.Add((double)item);
            }

        }
        double positiveRatio = (double)positive.Count() / num;
        double zeroRatio = (double)zeroes.Count() / num;
        double negativeRatio = (double)negative.Count() / num;

        Console.WriteLine(Math.Round(positiveRatio, 6));
        Console.WriteLine(Math.Round(negativeRatio, 6));
        Console.WriteLine(Math.Round(zeroRatio, 6));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
