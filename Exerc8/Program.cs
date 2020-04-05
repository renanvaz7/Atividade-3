using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double ImpostoRenda;

            Console.WriteLine("Digite o salário");
            salario = Double.Parse(Console.ReadLine());

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                ImpostoRenda = (salario - 2000.00) * 0.08;
                Console.WriteLine("R$" + ImpostoRenda);
            }
            else if (salario > 3000.00 && salario < 4500.00)
            {
                ImpostoRenda = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
                Console.WriteLine("R$" + ImpostoRenda);
            }
            else if (salario > 4500.00)
            {
                ImpostoRenda = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
                Console.WriteLine("R$" + ImpostoRenda);
            }
            Console.ReadKey();
        }
    }
}
