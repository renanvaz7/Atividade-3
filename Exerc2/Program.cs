using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;

            Console.WriteLine("Digite um número");
            entrada = Int32.Parse(Console.ReadLine());

            if (entrada % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            Console.ReadKey();  
        }
    }
}
