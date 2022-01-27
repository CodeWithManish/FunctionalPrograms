using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class SumOfThreeToZero
    {
        public void GetTripletSum()
        {
             Console.WriteLine("Enter the size of array: ");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the Element of Array: ");

             int[] arr = new int[num];


             for (int i = 0; i < arr.Length ; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());

                     for (int j = i + 1; j < arr.Length; j++)
                     {
                         for (int k = j + 1; k < arr.Length; k++)
                         {
                             int sum = arr[i] + arr[j] + arr[k];
                             if (sum == 0)
                             {

                                 Console.WriteLine("array : " + arr[i] + " : " + arr[j] + " : " + arr[k]);
                             }
                         }
                     }

             }
                 Console.ReadKey();
          }
            
     }
 }

