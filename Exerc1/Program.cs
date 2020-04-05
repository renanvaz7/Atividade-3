using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;

            Console.WriteLine("Digite um número");
            entrada = Int32.Parse(Console.ReadLine());

            if (entrada < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            Console.ReadKey();
        }
    }
}
