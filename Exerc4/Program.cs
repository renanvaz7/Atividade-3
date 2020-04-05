using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            double HoraInicial, HoraFinal;
            double duracao;

            Console.WriteLine("Qual a hora inicial do jogo?");
            HoraInicial = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a hora Final do jogo?");
            HoraFinal = Double.Parse(Console.ReadLine());

            if (HoraInicial < HoraFinal)
            {
                duracao = HoraFinal - HoraInicial;
                Console.WriteLine("O JOGO DUROU " + duracao + "HORA(S)");
            }
            else
            {
                duracao = 24 - HoraInicial + HoraFinal;
                Console.WriteLine("O JOGO DUROU " + duracao + "HORA(S)");
            }
            Console.ReadKey();
        }
    }
}
