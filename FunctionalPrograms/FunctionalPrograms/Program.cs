using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Program
    {
       
            static void Main(string[] args)
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter 1 to find the distance between two given points:\n" + 
                        "Enter 2 to print 2d Array:\n" + "Enter 3 for the Quadratic Root Equation:\n" +
                        "Enter 4 to get the Effective Temperature:\n" +
                        "Enter 5 to get triplet sum equal to zero: \n" +
                        "Enter 0 to Exit");

                    flag = true;

                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 0:
                            flag = false;
                            break;

                        case 1:
                            Distance distance = new Distance();
                            distance.Calc();
                            break;
                        case 2:
                            TwoDArray twoDArray = new TwoDArray();
                            twoDArray.Array();
                            break;

                        case 3:
                            QuadraticRootEquation qre = new QuadraticRootEquation();
                            qre.Find();
                            break;

                        case 4:
                            WindChill windChill = new WindChill();
                            windChill.Temperature();
                            break;

                        case 5:
                            SumOfThreeToZero sumOfThreeToZero = new SumOfThreeToZero();
                            sumOfThreeToZero.GetTripletSum();
                            break;
                }
                }
            }
       
    }
    
}

    

