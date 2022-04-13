using System;
using System.Globalization;

namespace NewDateTimeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"Today is {today.Day} of {today.ToString("MMMM")} of {today.Year}. It's {today.ToString("HH:mm:ss")}");
        }
    }
}
