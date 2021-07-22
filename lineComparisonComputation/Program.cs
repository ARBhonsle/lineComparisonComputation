using System;

namespace lineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] point=new int[4];
            Console.WriteLine("Welcome to Line Comparison Computation Program!");
            Console.WriteLine("Length calculation between two points in a line");
            Console.WriteLine("Give first point coordinate:");
            Console.WriteLine("X: ");
            point[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            point[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give second point coordinate:");
            Console.WriteLine("X: ");
            point[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            point[3] = Convert.ToInt32(Console.ReadLine());
            ILineCompute line = new LineCompute(point);
            line.LengthCalc();
        }
    }
}
