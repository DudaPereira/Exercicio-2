
using System;

namespace Exercico_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo! Em que ano você nasceu?");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano nós estamos?");
            int ano = int.Parse(Console.ReadLine());

            int resultado = ano - nascimento;
            Console.WriteLine("Sua idade é" + resultado + "anos");

            double semanas = (nascimento * 365) / 7;
            Console.WriteLine( "Sua idade convertida em semnas é:" + semanas);
        }
    }
}
