using ClassicRandomBit.Application;
using QuantumRandomBit.Application.QSharpSimulator.Vector;
using System;

namespace QSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ***********************************
            // classic pseudorandom bits generator

            var classicPseudorandom = new ClassicPseudorandomBitGenerator();
            classicPseudorandom.GeneratePseudorandomBit();

            // ***********************************
            // display computed quantum vector with given coordinates

            //var quantumVector = new QuantumVector(1, 1);
            //Console.WriteLine(quantumVector.Result);
            //Console.ReadKey();
        }
    }
}