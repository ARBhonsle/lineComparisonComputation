using System;

namespace lineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");
            ILineCompute line = new LineCompute();
            //line.LengthCalc();
            line.CompareLength();
        }
    }
}
