using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsPrime = true;
            Console.WriteLine("Prime Numbers Between 1 To 100: ");
            for (int k = 2; k <= 100; k++)
            {
                for (int l = 2; l <= k; l++)
                {
                    if (k != l && k % l == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                Console.Write("\n" + k);
                IsPrime = true;
            } Console.ReadKey();
        }
    }
}
