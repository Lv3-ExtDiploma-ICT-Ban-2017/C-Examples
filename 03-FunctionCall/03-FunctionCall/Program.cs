/*
     MIT License
    
    Copyright (c) 2018 Adam Allport
    
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
    
    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.
    
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/


using System;
using System.Collections.Generic;

namespace _05_FunctionCall
{
    internal static class Program
    {
        private static void Main()
        {
            var names = new[]
            {
                "Alex G", "George", "AAllport",
                "Nathan", "Arnold", "Alex S",
                "Owain", "James", "Eliott",
                "Leto", "Dan"
            };
            const string needle = "a";
            var occurances = GetItemsWithNeedle(needle, names, false);
            Console.WriteLine("Given the array [\"{0}\"]", string.Join("\",\"", names));
            Console.WriteLine("The needle '{0}' occurs in the following {1} item(s):", needle, occurances.Length);
            foreach (var item in occurances)
                Console.WriteLine(" - \"{0}\"", item);
        }

        private static string[] GetItemsWithNeedle(string needle, IEnumerable<string> heystack, bool caseSensitive)
        {
            //Normalisation: So, the case matters with `item.Contains`
            //For this reason, if `caseSensitive` is true, we want to make everything lowercase 
            var normNeedle = caseSensitive ? needle : needle.ToLower();
            var matches = new List<string>();
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var item in heystack)
            {
                var normItem =
                    caseSensitive ? item : item.ToLower(); //Cant do this on #30, beacuse it breaks the return
                if (normItem.Contains(normNeedle)) //This is put on 2 lines beacuse 4 looks ugly
                    matches.Add(item);
            }

            return matches.ToArray();
        }
    }
}