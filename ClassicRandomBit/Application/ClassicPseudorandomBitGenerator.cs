using System;
using System.Threading;
using ClassicRandomBit.Interfaces;

namespace ClassicRandomBit.Application
{
    public class ClassicPseudorandomBitGenerator : IClassicPseudorandomBitGenerator
    {
        public ClassicPseudorandomBitGenerator()
        {

        }

        private int ComputePseudorandomBit()
        {
            int bit = 0;
            var random = new Random();

            var randomNumber = random.NextDouble();

            return bit = randomNumber <= 0.5 ? 0 : 1;
        }

        public void GeneratePseudorandomBit()
        {
            while (true)
            {
                var pseudorandomBit = this.ComputePseudorandomBit();
                Console.WriteLine($"Pseudorandom bit generated is: {pseudorandomBit}");

                Thread.Sleep(500);
            }
        }
    }
}
