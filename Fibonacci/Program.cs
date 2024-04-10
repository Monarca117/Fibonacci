using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 20;
            int n1 = 0;
            int n2 = 1;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            int s = n1 + n2;

            while(s < limit) 
            {
                Console.WriteLine(s);
                n1 = n2;
                n2 = s;
                s = n1 + n2;
            }
        }
    }
}
