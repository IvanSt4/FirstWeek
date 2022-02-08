using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        string input = Console.ReadLine();
        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            camelCase(input);
            input = Console.ReadLine();
        }
        

    }

    private static void camelCase(string input)
    {
        char[] MyChar = { '(', ')', ' ' };

        string[] command = input.TrimEnd(MyChar).Split(';', StringSplitOptions.RemoveEmptyEntries);

        string splitOrCombine = command[0];  // S or C
        string methodClassVariable = command[1];  // M , C or V
        string words = command[2];

        string pattern = @"([a-z]+)|([A-Z]{1}[a-z]*)";

        Regex regex = new Regex(pattern);

        string[] word;
        word = Regex.Split(words, pattern).Where(str => !string.IsNullOrWhiteSpace(str)).ToArray();
        List<string> result = new List<string>();
        string item1;

        if (splitOrCombine == "S")
        {


            foreach (var item in word)
            {
                item1 = item.ToLower();
                result.Add(item1);
            }
            Console.WriteLine(String.Join(' ', result));
        }
        else //c
        {

            if (methodClassVariable == "M")
            {

                var sb = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(word[i].ToLower());
                    }
                    else
                    {
                        sb.Append(char.ToUpper(word[i][0]) + word[i].Substring(1));
                    }

                }
                sb.Append("()");

                Console.WriteLine(sb.ToString());
            }
            else if (methodClassVariable == "V")
            {
                var sb = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(word[i].ToLower());
                    }
                    else
                    {
                        sb.Append(char.ToUpper(word[i][0]) + word[i].Substring(1));
                    }

                }

                Console.WriteLine(sb.ToString());
            }
            else if (methodClassVariable == "C")
            {
                var sb = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {


                    sb.Append(char.ToUpper(word[i][0]) + word[i].Substring(1));


                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
