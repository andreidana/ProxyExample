using System;

namespace ProxyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractNumberGenerator numberGenerator = new ProxyNumberGenerator();

            Console.WriteLine(numberGenerator.GenerateNumber());
        }
    }
}
