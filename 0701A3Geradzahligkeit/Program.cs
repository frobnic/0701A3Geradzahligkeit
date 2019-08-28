using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0701A3Geradzahligkeit
{
    class Program
    {
        static Boolean AmIStraight(int a)
        {
            return (a % 2 == 0);
        }

        static void Main(string[] args)
        {
            int b = 0;

            Console.Write("Bitte erfassen sie eine Zahlin: ");
            if (int.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Die Geradzahligkeitsprüfung der Zahlin ergibt: {0}", AmIStraight(b));
        }
    }
}
