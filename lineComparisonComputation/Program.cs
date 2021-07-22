using System;

namespace lineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");
            Console.WriteLine("Length calculation between two points in a line");
            int[] point = new int[4];
            int[] point1 = new int[4];
            int j;
            for (int i=0;i<4;i++) 
            {
                j = (i < 2) ? 1 : 2;
                Console.WriteLine("Give "+j+" point coordinate: "+(i%2+1));
                Console.WriteLine("X: ");
                point[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y: ");
                point1[i] = Convert.ToInt32(Console.ReadLine());                
            }
            ILineCompute line = new LineCompute(point,point1);
            line.CompareLength();
        }
    }
}
