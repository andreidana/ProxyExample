using System;

namespace ProxyExample
{
    public class NumberGenerator: AbstractNumberGenerator
    {
        public override int GenerateNumber()
        {
            var rand = new Random();
            return rand.Next(1, 20000);
        }
    }
}