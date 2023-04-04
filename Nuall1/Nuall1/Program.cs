using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuall1

{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введіть висоту");
            x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть основу");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S = ");
            Console.WriteLine(x * y);
            Console.ReadLine();

        }
    }
}
