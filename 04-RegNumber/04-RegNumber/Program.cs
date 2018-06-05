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
using System.Linq;

namespace _04_RegNumber
{
    internal static class Program
    {
        private class InvalidChar
        {
            public readonly int Position;
            public readonly string Error;

            public InvalidChar(int position, string error)
            {
                Position = position;
                Error = error;
            }
        }

        private static readonly int[] TestTypes = {1, 1, 2, 2, 3, 4, 4, 4};

        private static void Main()
        {
            TryValidateReg("AA12 AAA");
            TryValidateReg("AA12AAAA");
            TryValidateReg("12AA 123");
            TryValidateReg("    1   ");
            TryValidateReg("        ");
        }

        private static void TryValidateReg(string regNum)
        {
            var errors = ValidateReg(regNum);
            if (errors.Length == 0)
                Console.WriteLine("Registration '{0}' is valid", regNum);
            else
            {
                Console.WriteLine("Registration '{0}' has {1} error{2}",
                    regNum, errors.Length, errors.Length != 1 ? "s" : "");
                foreach (var iC in errors)
                    Console.WriteLine(" - {0}: {1}", iC.Position + 1, iC.Error);
            }
        }

        private static InvalidChar[] ValidateReg(string regNum)
        {
            var errors = new List<InvalidChar>();
            for (var i = 0; i < regNum.Length; i++)
            {
                var regPart = regNum[i];
                var testPart = TestTypes[i];
                switch (testPart)
                {
                    case 1:
                        if (!(char.IsLetter(regPart) && ! new[] {'Q', 'Z', 'I'}.Contains(regPart)))
                            errors.Add(new InvalidChar(i, "Must be a letter but not Q,Z or I"));
                        break;
                    case 2:
                        if (!char.IsDigit(regPart))
                            errors.Add(new InvalidChar(i, "Must be a digit"));
                        break;
                    case 3:
                        if (!char.IsWhiteSpace(regPart))
                            errors.Add(new InvalidChar(i, "Must be a space"));
                        break;
                    case 4:
                        if (!(char.IsLetter(regPart) && ! new[] {'Q', 'Z'}.Contains(regPart)))
                            errors.Add(new InvalidChar(i, "Must be a letter but not Q or Z"));
                        break;
                    default:
                        errors.Add(new InvalidChar(i, "Cannot handle: " + regPart));
                        break;
                }
            }

            return errors.ToArray();
        }
    }
}