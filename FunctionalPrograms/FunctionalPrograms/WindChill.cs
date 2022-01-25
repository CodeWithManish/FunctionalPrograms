using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class WindChill
    {
        public void Temperature()
        {
            double t, v;
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a tempeture in Fahrenheit :" + t);

            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the  wind speed of mph " + v);

            double windChillTemp = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);

            Console.WriteLine("The wind chill is" + windChillTemp);

        }
    }
}
