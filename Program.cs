using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, R;
            R = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n = 3.14159;
            
            A = (3.14159 * R * R);
                        
            Console.WriteLine($"area = {A.ToString("F4", CultureInfo.InvariantCulture)}" + "\n");
            Console.ReadLine();
        }
    }
}