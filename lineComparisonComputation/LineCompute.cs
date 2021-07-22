using System;
using System.Collections.Generic;
using System.Text;

namespace lineComparisonComputation
{
    class LineCompute: ILineCompute
    {
        int[] point = new int[4];
        public LineCompute(int[] point)
        {
            for(int i = 0; i < point.Length; i++)
            {
                this.point[i] = point[i];
            }
        }
        public void LengthCalc()
        {
            Double lineLength = Math.Sqrt(Math.Pow(point[0] - point[2], 2) + Math.Pow(point[1] - point[3], 2));
            Console.WriteLine("Length of line (within given points) :"+ lineLength);
        }
    }
}
