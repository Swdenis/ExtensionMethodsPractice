using System;
using AmazingExtensions;

namespace ExtenstionMethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Evil clones are wreaking havoc. Help!";
            Console.Write(message.IsDistressCall());

        }
    }
}
