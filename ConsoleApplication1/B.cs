using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long s = long.Parse(input[0]);
            long vOne = long.Parse(input[1]);
            long vTwo = long.Parse(input[2]);

            long x = 0;
            long y = 0;

            if (vOne >= vTwo)
            {
                x = vOne;
                y = vTwo;
            }
            else
            {
                y = vOne;
                x = vTwo;
            }

            long a = s / x;
            int b = 0;

            bool notFound = false;

            while ((a * x) + (b * y) != s && !notFound)  
            {
                a--;
                if (a == -1)
                {
                    notFound = true;
                }
                else
                {
                    b = 0;
                    while ((b * y) < s - (a * x))
                    {
                        b++;
                    }
                }
            }

            if(notFound)
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                Console.WriteLine(a + " " + b);
            }

            

            Console.ReadKey();
        }
    }
}
