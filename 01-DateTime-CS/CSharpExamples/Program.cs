using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store the current cursor position so that we can reset
            int[] cursorPos = { Console.CursorLeft, Console.CursorTop };
            while (true)
            {
                Console.SetCursorPosition(cursorPos[0], cursorPos[1]);
                DateTime today = DateTime.Now.Date;
                TimeSpan now = DateTime.Now.TimeOfDay;
                Console.WriteLine(today.ToShortDateString());
                Console.WriteLine(now);

                //Deltas
                Console.WriteLine("Two weeks from now is: " + today.AddDays(14));
                Console.WriteLine("Two weeks from now is: " + today.AddDays(14).ToShortDateString());
                Console.WriteLine("Three weeks ago was: " + today.AddDays(7 * -3));
                Console.WriteLine("Three weeks ago was: " + today.AddDays(7 * -3).ToLongDateString());
                Console.WriteLine("In 4 hours the time will be : " + now.Subtract(new TimeSpan(4,0,0)));

                Thread.Sleep(100);
            }
        }
    }
}
