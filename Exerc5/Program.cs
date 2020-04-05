using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Quantidade;
            double ValorTotal;
            int menu;

            Console.WriteLine("Digite a quantidade do item");
            Quantidade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("---     CÓDIGO                  ESPECIFICAÇÃO                   PREÇO     ---");
            Console.WriteLine("---                                                                       ---");
            Console.WriteLine("---       1                    Cachorro quente                  R$4.00    ---");
            Console.WriteLine("---       2                        X-Salada                     R$4.50    ---");
            Console.WriteLine("---       3                        X-Bacon                      R$5.00    ---");
            Console.WriteLine("---       4                    Torrada Simples                  R$2.00    ---");
            Console.WriteLine("---       5                     Refrigerante                    R$1.50    ---");
            Console.WriteLine("---                                                                       ---");
            Console.WriteLine("-----------------------------------------------------------------------------");
            menu = Int32.Parse(Console.ReadLine());
                        
            switch (menu)
            {
                case 1:
                    ValorTotal = Quantidade * 4.00;
                    Console.WriteLine("Total: " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    ValorTotal = Quantidade * 4.50;
                    Console.WriteLine("Total: " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    ValorTotal = Quantidade * 5.00;
                    Console.WriteLine("Total: " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    ValorTotal = Quantidade * 1.50;
                    Console.WriteLine("Total: " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            Console.ReadKey();
        }
    }
}
