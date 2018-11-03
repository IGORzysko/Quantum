using ClassicRandomBit.Application;

namespace QSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // classic pseudorandom bits generator

            var classicPseudorandom = new ClassicPseudorandomBitGenerator();
            classicPseudorandom.GeneratePseudorandomBit();
        }
    }
}