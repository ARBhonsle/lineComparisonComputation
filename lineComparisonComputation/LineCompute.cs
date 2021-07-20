using System;
using System.Collections.Generic;
using System.Text;

namespace lineComparisonComputation
{
    class LineCompute: ILineCompute
    {
        public void LengthCalc()
        {
            int[] x = new int[2];
            int[] y= new int[2];
            Console.WriteLine("Length calculation between two points in a line");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Give "+(i+1)+" point coordinate:");
                Console.WriteLine("X: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            Double lineLength = Math.Sqrt(Math.Pow(x[0] - x[1], 2) + Math.Pow(y[0] - y[1], 2));
            Console.WriteLine("Length of line (within given points) :"+ lineLength);
        }
        public void CompareLength()
        {
            int[] x=new int[4];
            int[] y = new int[4];
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Give Coordinate for Line "+(j + 1));
                Console.WriteLine("X:");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y: ");
                y[i]= Convert.ToInt32(Console.ReadLine());
            }
            if(x[0].Equals(x[2]) && x[1].Equals(x[3]))
            {
                if (y[0].Equals(y[2]) && y[1].Equals(y[3]))
                {
                    Console.WriteLine("Line Equal");
                }
                else 
                {
                    Console.WriteLine("Line Length Not Equal");
                }
            }else if (x[0].Equals(x[3]) && x[1].Equals(x[2]))
            {
                if(y[0].Equals(y[3]) && y[1].Equals(y[2]))
                {
                    Console.WriteLine("Line Equal");
                }
                else
                {
                    Console.WriteLine("Line Length Not Equal");
                }
            }
            else
            {
                Double lengthLine1 = Math.Sqrt(Math.Pow(x[0] - x[1], 2) + Math.Pow(y[0] - y[1], 2));
                Double lengthLine2 = Math.Sqrt(Math.Pow(x[2] - x[3], 2) + Math.Pow(y[2] - y[3], 2));
                if (lengthLine1 != lengthLine2)
                {
                    Console.WriteLine("Line Length Not Equal");
                }
                else
                {
                    Console.WriteLine("Line lengths Equal");
                }
            }
        }
    }
}
