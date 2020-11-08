using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Utils
    {
        public int Greater(int x, int y)
        {
            int max = Math.Max(x, y);
            return max;
        }

        public void Swap (ref int x, ref int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;

        }

        public void Factorial(int x)
        {
            int fact = 1;
            if(x == 0)
            {
                Console.WriteLine("Factorial of zero is 1");
                return;
            }
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of {0} is {1} \n",x,fact);
        }

        public int FactorialRecursion(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            
            return x * FactorialRecursion(x-1);
            
        }
    }
}
