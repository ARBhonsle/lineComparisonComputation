using System;
using System.Collections.Generic;
using System.Text;

namespace lineComparisonComputation
{
    class LineCompute: ILineCompute
    {
        public void LengthCalc()
        {
            Console.WriteLine("Length calculation between two points in a line");
            Console.WriteLine("Give first point coordinate:");
            Console.WriteLine("X: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give second point coordinate:");
            Console.WriteLine("X: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double lineLength = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("Length of line (within given points) :"+ lineLength);
        }
    }
}
