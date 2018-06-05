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
using System.Threading;

namespace E_01_DateTime_CS
{
    internal static class Program
    {
        public static void Main()
        {
            int[] cursorPos = {Console.CursorLeft, Console.CursorTop};
            while (true)
            {
                Console.SetCursorPosition(cursorPos[0], cursorPos[1]);
                var today = DateTime.Now.Date;
                var now = DateTime.Now.TimeOfDay;
                Console.WriteLine(today.ToShortDateString());
                Console.WriteLine(now);

                //Deltas
                Console.WriteLine("Two weeks from now is: " + today.AddDays(14));
                Console.WriteLine("Two weeks from now is: " + today.AddDays(14).ToShortDateString());
                Console.WriteLine("Three weeks ago was: " + today.AddDays(7 * -3));
                Console.WriteLine("Three weeks ago was: " + today.AddDays(7 * -3).ToLongDateString());
                Console.WriteLine("In 4 hours the time will be : " + now.Subtract(new TimeSpan(4, 0, 0)));

                Thread.Sleep(100);
            }
        }
    }
}