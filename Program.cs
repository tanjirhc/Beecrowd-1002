using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double A = Math.PI * R * R;
            Console.WriteLine("Area of circle is: \n" + A);

            Console.ReadLine();
        }
    }
}
