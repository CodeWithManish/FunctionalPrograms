using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Distance
    {

        public void Calc()
        {
            Console.WriteLine("Enter the First Point of the Cooridinate  \n");
            int x1, y1;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            x1 = int.Parse(numbers[0]);
            y1 = int.Parse(numbers[1]);

            Console.WriteLine("Enter the Second Point of the Cooridinate  \n");
            int x2, y2;
            line = Console.ReadLine();
            numbers = line.Split(' ');
            x2 = int.Parse(numbers[0]);
            y2 = int.Parse(numbers[1]);

            double f = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Euclidan Distance between points is  :" + f);


        }
    }
}
