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
        string input = Console.ReadLine();
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        while (true)
        {
            
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            char[] MyChar = { '(', ')', ' ' };

            string[] command = input.TrimEnd(MyChar).Split(';');


            string splitOrCombine = command[0];  // S or C
            string methodClassVariable = command[1];  // M , C or V
            string words = command[2];

            string pattern = @"([a-z]+)|([A-Z]{1}[a-z]*)";

            string[] word;
            word = Regex.Split(words, pattern).Where(str => !string.IsNullOrWhiteSpace(str)).ToArray();
      


            if (splitOrCombine == "S")
            {
                var sb = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {

                    sb.Append(word[i].ToLower());
                    sb.Append(" ");
                }

                Console.WriteLine(sb.ToString().TrimEnd());
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
            input = Console.ReadLine();
        }

        
    }
}
