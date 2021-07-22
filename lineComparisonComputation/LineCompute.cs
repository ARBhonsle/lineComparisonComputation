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
                Double lengthLine1 = Math.Sqrt(Math.Pow(this.point[0] - this.point[1], 2) + Math.Pow(point1[0] - point1[1], 2));
                Double lengthLine2 = Math.Sqrt(Math.Pow(this.point[2] - this.point[3], 2) + Math.Pow(point1[2] - point1[3], 2));
                if(lengthLine1 != lengthLine2)
                {
                    Console.WriteLine("Line Length Not Equal");
                }
                else
                {
                    Console.WriteLine("Line lengths Equal");
                }
            }
        }
        public void LineCompare()
        {
            int[] x = new int[4];
            int[] y = new int[4];
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Give Coordinate for Line " + (j + 1));
                Console.WriteLine("X:");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (x[0].Equals(x[2]) && x[1].Equals(x[3]))
            {
                if (y[0].Equals(y[2]) && y[1].Equals(y[3]))
                {
                    Console.WriteLine("Line lengths Equal");
                }
                else
                {
                    if (y[0].Equals(y[2]))
                    {
                        if (y[1] > y[3])
                        {
                            Console.WriteLine("Line 1 length is Greater");
                        }
                        else
                        {
                            Console.WriteLine("Line 2 length is Greater");
                        }
                    }
                    if (y[1].Equals(y[3]))
                    {
                        if (y[0] > y[2])
                        {
                            Console.WriteLine("Line 1 length is Greater");
                        }
                        else
                        {
                            Console.WriteLine("Line 2 length is Greater");
                        }
                    }
                }
            }
            else if (x[0].Equals(x[3]) && x[1].Equals(x[2]))
            {
                if (y[0] == y[3] && y[1] == y[2])
                {
                    Console.WriteLine("Line lengths Equal");
                }
                else
                {
                    if (y[0].Equals(y[3]))
                    {
                        if (y[1] > y[2])
                        {
                            Console.WriteLine("Line 1 length is Greater");
                        }
                        else
                        {
                            Console.WriteLine("Line 2 length is Greater");
                        }
                    }
                    if (y[1].Equals(y[2]))
                    {
                        if (y[0] > y[3])
                        {
                            Console.WriteLine("Line 1 length is Greater");
                        }
                        else
                        {
                            Console.WriteLine("Line 2 length is Greater");
                        }
                    }
                }
            }
            else
            {
                Double lengthLine1 = Math.Sqrt(Math.Pow(x[0] - x[1], 2) + Math.Pow(y[0] - y[1], 2));
                Double lengthLine2 = Math.Sqrt(Math.Pow(x[2] - x[3], 2) + Math.Pow(y[2] - y[3], 2));
                if (lengthLine1 != lengthLine2)
                {
                    Console.WriteLine("Line Length Not Equal");
=======
                Double lengthLine1 = Math.Sqrt(Math.Pow(this.point[0] - this.point[1], 2) + Math.Pow(this.point1[0] - this.point1[1], 2));
                Double lengthLine2 = Math.Sqrt(Math.Pow(this.point[2] - this.point[3], 2) + Math.Pow(this.point1[2] - this.point1[3], 2));
                if (lengthLine1 != lengthLine2)
                {
                    Console.WriteLine("Line Lengths Not Equal");
>>>>>>> UC2-lineEquality
                }
                else
                {
                    Console.WriteLine("Line lengths Equal");
                }
            }
        }
    }
}
