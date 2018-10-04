using System;

namespace SandboxCore
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Adding 2 + 3 = {Calculator.Add(2,3)}");
        }
    }
}