using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class1
    {
        // returns a double - when the method is "void" it means it does not return anything
         public static double sum(double a, double b)
        {
            return a + b;
        }

        public static int Min(int s, int c)
        {
            if (s > c) return s;
            else return c;
        }

        static double inputNumber() {
           // Program.printMessage();
            double a = double.Parse(Console.ReadLine());
            return a;
        }
    }
}
