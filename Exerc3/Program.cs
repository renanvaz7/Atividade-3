using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada1, entrada2;
            int divisao;

            Console.WriteLine("Digite um número");
            entrada1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            entrada2 = Int32.Parse(Console.ReadLine());

            if (entrada1 > entrada2)
            {
                if (entrada1 % entrada2 == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não São Múltiplos");
                }                
            }
            else
            {
                if (entrada2 % entrada1 == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não São Múltiplos");
                }                
            }
            Console.ReadKey();
        }
    }
}
