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

namespace E_07_Calculator_CS
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Allport's amazing calculator."); // Sexy message

            while (true) // say to run for ever and ever and ever...
            {
                Console.WriteLine("Please enter 2 numbers to multiply.");

                int number1, number2, result = 0; // Declare the number vars to stop ide killing me
                string action;
                
                try // try to run something
                {
                    // get user input and covert it to a int :P
                    number1 = Convert.ToInt32(PromptForInput("First number: "));
                    number2 = Convert.ToInt32(PromptForInput("Second number: "));

                    // find what action they want to preform 
                    action = PromptForInput("What would you like to do: ");

                    switch (action)
                    {
                        case "add":
                            result = number1 + number2;
                            break;
                        case "sub":
                            result = number1 - number2;
                            break;
                        case "times":
                            result = number1 * number2;
                            break;
                        case "divide":
                            result = number1 / number2;
                            break;
                        case "pow":
                            result = number1 ^ number2;
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (Exception e) // when/if it errors run
                {
                    Console.WriteLine("You melon!");
                    continue; // move to the next step in loop (stop running the current one)
                }
                
                // say we are calculating when we are not yet...
                Console.WriteLine("Calculating (" + number1 + " " + action + " " + number2 + ")...");

                Console.WriteLine("Result: " + result); // output the result
            }
        }
        
        /*
         * declare a new function that will return a string
         * with the parameter/argument message with type string
         * 
         */
        private static string PromptForInput(string message)
        {
            Console.Write(message); // send the prompt message
            return Console.ReadLine(); // return what the user inputs
        }
    }
}