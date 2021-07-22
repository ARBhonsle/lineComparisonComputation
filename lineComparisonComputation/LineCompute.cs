using System;
using System.Collections.Generic;
using System.Text;

namespace lineComparisonComputation
{
    class LineCompute: ILineCompute
    {
        readonly int[] point = new int[4];
        readonly int[] point1 = new int[4];
        public LineCompute(int[] point)
        {
            for (int i = 0; i < point.Length; i++)
            {
                this.point[i] = point[i];
            }
        }
        public LineCompute(int[] point,int[] point1)
        {
            for (int i = 0; i < point.Length; i++)
            {
                this.point[i] = point[i];
                this.point1[i] = point1[i];
            }
        }
        public void LengthCalc()
        {
            Double lineLength = Math.Sqrt(Math.Pow(point[0] - point[2], 2) + Math.Pow(point[1] - point[3], 2));
            Console.WriteLine("Length of line (within given points) :"+ lineLength);
        }
        public void CompareLength()
        {
            if(this.point[0].Equals(this.point[2]) && this.point[1].Equals(this.point[3]))
            {
                if (this.point1[0].Equals(this.point1[2]) && this.point1[1].Equals(this.point1[3]))
                {
                    Console.WriteLine("Line lengths Equal");
                }
                else 
                {
                    Console.WriteLine("Line Lengths Not Equal");
                }
            }else if (this.point[0].Equals(this.point[3]) && this.point[1].Equals(this.point[2]))
            {
                if(this.point1[0].Equals(this.point1[3]) && this.point1[1].Equals(this.point1[2]))
                {
                    Console.WriteLine("Line lengths Equal");
                }
                else
                {
                    Console.WriteLine("Line Lengths Not Equal");
                }
            }
            else
            {
                Double lengthLine1 = Math.Sqrt(Math.Pow(this.point[0] - this.point[1], 2) + Math.Pow(this.point1[0] - this.point1[1], 2));
                Double lengthLine2 = Math.Sqrt(Math.Pow(this.point[2] - this.point[3], 2) + Math.Pow(this.point1[2] - this.point1[3], 2));
                if (lengthLine1 != lengthLine2)
                {
                    Console.WriteLine("Line Lengths Not Equal");
                }
                else
                {
                    Console.WriteLine("Line lengths Equal");
                }
            }
        }
    }
}
