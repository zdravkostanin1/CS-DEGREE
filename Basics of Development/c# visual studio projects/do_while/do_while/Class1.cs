using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("kolko sa ocenkite");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vavedi chislo");
                double a = double.Parse(Console.ReadLine());
                while (a < 2 || a > 6)
                {
                    Console.WriteLine("nevalidna ocenka, vavedi pak");
                    a = double.Parse(Console.ReadLine());
                }
                sum += a;
            }
        }
    }
}
