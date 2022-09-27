using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, k;
            Console.WriteLine("Enter a word");
            s= Console.ReadLine();
            Console.WriteLine("Please enter the character you want to check?");
            k= Console.ReadLine();
            if (s.Contains(k))
                Console.WriteLine(k + " found!");
            else
                Console.WriteLine(k + " not found!");

            Console.ReadKey();
        }
    }
}
