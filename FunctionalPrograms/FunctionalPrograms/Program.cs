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
                    Console.WriteLine(" Enter 1 to find the distance between two given points\n " + 
                        " Enter 2 to print 2d Array:\n " + " Enter 0 to Exit ");

                    flag = true;

                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 0:
                            flag = false;
                            break;

                        case 1:
                            Distance distance = new Distance();
                            distance.calc();
                            break;
                        case 2:
                            TwoDArray twoDArray = new TwoDArray();
                            twoDArray.Array();
                            break;
                }
                }
            }
       
    }
    
}

    

