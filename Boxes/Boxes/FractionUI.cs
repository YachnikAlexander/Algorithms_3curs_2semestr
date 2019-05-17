using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    static class FractionUI
    {
        public static double EnterFraction()
        {
            Console.WriteLine("Enter numerator");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter denominator");
            double denominator = Convert.ToDouble(Console.ReadLine());
            return numerator/denominator;
        }
    }
}
