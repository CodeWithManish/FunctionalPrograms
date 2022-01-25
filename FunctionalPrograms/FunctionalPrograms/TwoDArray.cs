using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class TwoDArray
    {
        public void Array()
        {
            int row, col;
            Console.WriteLine("Enter the number of Row and Column:");
            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            Console.WriteLine("Enter the Element:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(arr);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
