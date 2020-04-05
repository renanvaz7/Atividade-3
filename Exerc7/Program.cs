using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Digite o ponto x");
            x = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ponto y");
            y = Double.Parse(Console.ReadLine());

            if (x ==0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0 )
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
            Console.ReadKey();
        }
    }
}
