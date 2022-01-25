using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuadraticRootEquation
    {
        public void Find()
        {
            double a, b, c;
            Console.WriteLine("Enter the a,b,c from ax^2 + bx + c = 0 ");
            string input = Console.ReadLine();
            string[] ar = input.Split(' ');
            a = int.Parse(ar[0]);
            b = int.Parse(ar[1]);
            c = int.Parse(ar[2]);
            double Discriminant = Math.Sqrt(b * b - 4 * a * c);
            if (Discriminant < 0)
            {
                Console.WriteLine("Roots are Imaginary");
            }
            else
            {
                double R1 = (-b + Discriminant) / 2 * a;
                double R2 = (-b - Discriminant) / 2 * a;
                Console.WriteLine("The roots are :" + R1 + " " + R2 + "\n");
            }
        }
    }
}
