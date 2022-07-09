using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparison
    {
        double LineLength;

        public void calcLineLength()
        {
            // Taking input from user of X-Y Coordinates.
            Console.WriteLine("Enter the the point 1 Coordinate of X1 :  ");
            int X1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 2 Coordinate of X2 :  ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 1 Coordinate of Y2:  ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 1 Coordinate of Y2 :  ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            LineLength= Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            LineLength= Math.Sqrt(LineLength);
            Console.WriteLine("\nLength of the Line : {0}",LineLength);


        }

    }
}
