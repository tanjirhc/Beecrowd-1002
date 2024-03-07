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
            double R = Convert.ToDouble(Console.ReadLine());
            double n = 3.14159;
            double A = n * R * R;
            Console.WriteLine(A + "\n");
            Console.ReadLine();
        }
    }
}