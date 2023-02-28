using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = D;
            double a = myDelegate(1);
            Console.WriteLine(a);

            myDelegate = S;
            double b = myDelegate(1);
            Console.WriteLine(b);

            myDelegate = V;
            double c = myDelegate(1);
            Console.WriteLine(c);
        }

        static double D(double R) => 2 * Math.PI * R;
        static double S(double R) => Math.PI * R * R;
        static double V(double R) => (4 * Math.PI * R * R * R) / 3;

    
    }

   

}

    
   

