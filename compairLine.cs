using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineComparison
{
    public class compairLine
    {
        public void line()
        {
            Console.WriteLine("Welcome to line Comparison Program");
            Console.WriteLine("Write Value for first line");
            Console.WriteLine("Write First number");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Second number");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Third number");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Fourth number");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z1 = x2 - x1;
            int z2 = y2 - y1;
            double num1 = Math.Pow(z1, 2);
            double num2 = Math.Pow(z2, 2);
            double distance = Math.Sqrt(num1 + num2);
            Console.WriteLine("distance : " + distance);


            Console.WriteLine("Write Value for first line");
            Console.WriteLine("Write First number");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Second number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Third number");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Fourth number");
            int b2 = Convert.ToInt32(Console.ReadLine());

            int c1 = a2 - a1;
            int c2 = b2 - b1;
            double numb1 = Math.Pow(c1, 2);
            double numb2 = Math.Pow(c2, 2);
            double distanceOne = Math.Sqrt(numb1 + numb2);

            Console.WriteLine("distance1 : " + distanceOne);

            if (distance == distanceOne)
            {
                Console.WriteLine("equal");
            }
            else if (distance < distanceOne)
            {
                Console.WriteLine("distance < distanceOne");
            }
            else
            {
                Console.WriteLine("distance > distanceOne");
            }
        }
        public static void Main(string[]strings)
        {
            compairLine compair = new compairLine();
            compair.line();
        }

    }
}
