using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparison
    {
        double Line_1_Length;
        double Line_2_Length;

        public void calcLineLength()
        {
            // Taking Input from users of Line 1 X-Y Coordinates
            Console.WriteLine("Enter the the point 1 Coordinate of X1 :  ");
            int X1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 2 Coordinate of X2 :  ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 1 Coordinate of Y2:  ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 1 Coordinate of Y2 :  ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            // Taking Input from users of Line 2 X-2 Coordinates
            Console.WriteLine("Enter the the point 1 Coordinate of X3 :  ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 2 Coordinate of X4 :  ");
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 1 Coordinate of Y3:  ");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the the point 1 Coordinate of Y4 :  ");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            // calc line 1 Length
            Line_1_Length = Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            Line_1_Length = Math.Sqrt(Line_1_Length);
            Console.WriteLine("\nLength of the Line 1 : {0}", Line_1_Length);

            // calc line 2 Length
            Line_2_Length = Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2);
            Line_2_Length = Math.Sqrt(Line_2_Length);

            Console.WriteLine("Length of the Line 2 : {0}\n", Line_2_Length);

          
        }
        public void CheckLengthEqual()
        {
            if(Line_1_Length == Line_2_Length)
            {
                Console.WriteLine("The Length of Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("The Length of Both Lines Are Not Equal");
            }
        }

    }
}
