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

namespace E_05_Polymorphic_CS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("E-05-Polymorphic");
            DoAdHocPoly("a","b");//This will cause concatenation
            DoAdHocPoly(1,2);//This will cause addition
        }

        private static void DoAdHocPoly(string value, string another)
        {
            Console.WriteLine($"This will run because {value} {another} is a string");
        }

        private static void DoAdHocPoly(int value, int another)
        {
            Console.WriteLine($"This will run because {value+another} is an int");
        }
    }
}