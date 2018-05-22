using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Randomness_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "J", "F", "M" };
            Random rnd = new Random();

            while (true)
            {
                int month = rnd.Next(0, months.Length);
                Console.WriteLine("Month {0:D2} is {1}", month + 1, months[month]);
                //Thread.Sleep(10);
            }
        }
    }
}
