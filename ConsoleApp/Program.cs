using System;
using System.Linq;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            Enumerable
                .Range(1, 3)
                .Select(x => x * 2)
                .ToList()
                .ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}