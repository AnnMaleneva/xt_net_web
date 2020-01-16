using System;
using System.Text.RegularExpressions;

namespace Task07
{
    class RegexForSearch
    {
        public void DataSearch(string input) 
        {
            Regex dataRegex = new Regex(@"([0-2][0-9]|[0-3][0-1])-(0[1-9]|1[0-2])-[0-2][0-9][0-9][0-9]");

            if (dataRegex.IsMatch(input))
                Console.WriteLine("This string contains the date.");
            else
                Console.WriteLine("This string does not contain a date.");
        }

        public static string HTMLReplace(string input) 
        {
            var result = Regex.Replace(input, @"(<.*?>)", "_");

            return result; 
        }

        public void EmailSearch(string input) 
        {
            Regex emailRegex = new Regex(@"[a-zA-z0-9-._]+@(?:[a-z0-9]+\.)+[a-z]{2,6}");

            MatchCollection res3 = emailRegex.Matches(input);

            foreach (Match item in res3)
            {
                Console.WriteLine(item);
            }
        }

        public void WhatNotation(string input) 
        {

            Regex numPrime = new Regex(@"^-?\d+(\.\d+)?$");
            Regex numSci = new Regex(@"^-?\d+\.\d+e-[1-9]{1,}$");

            if (numPrime.IsMatch(input))
            {
                Console.WriteLine("This number is in normal notation.");
            }
            else if (numSci.IsMatch(input))
            {
                Console.WriteLine("This number is in scientific notation.");
            }
            else
            {
                Console.WriteLine("This is not a number.");
            }
        }

        public void TimeSearch(string input)
        {
            Regex timeRegex = new Regex(@"(([0-1]?[0-9])|([0-2][0-3])):([0-5][0-9])");

            MatchCollection result = timeRegex.Matches(input);

            int count = 0;

            foreach (Match item in result)
            {
                count++;
            }

            Console.WriteLine("В строке время встречается {0} раз(а).", count);
        }
    }
}
