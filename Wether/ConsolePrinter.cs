using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherLibrary
{
    public class ConsolePrinter: IPrinter
    {
        private ConsoleColor color;

        public ConsolePrinter(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
    }
}
