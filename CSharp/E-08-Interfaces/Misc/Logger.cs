using System;
using E_08_Interfaces.Interfaces;

namespace E_08_Interfaces.Misc
{
    public static class Logger
    {
        public static void log(this ILogable obj, string message, LogLevel level = LogLevel.INFO)
        {
            var module = obj.GetType().ToString().Substring(16);
            var output = $"{level.ToString()}\t({module}) {message}";
            if (level < LogLevel.ERROR)
                Console.Out.WriteLine(output);
            else
                Console.Error.WriteLine(output);
        }
    }
}