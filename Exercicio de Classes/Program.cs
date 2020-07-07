using System;

namespace Exercicio_de_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            {
                Console.Write("insira seu nome:");
                p1.Nome = Console.ReadLine();

                Console.Write("insira sua idade:");
                p1.Idade = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.Write("insira seu nome:");
                p2.Nome = Console.ReadLine();

                Console.Write("insira sua idade:");
                p2.Idade = int.Parse(Console.ReadLine());

                if (p1.Idade > p2.Idade)
                {
                    Console.WriteLine(p1.Nome);
                }

                else
                {
                    Console.WriteLine(p2.Nome);
                }
            }
        }
    }
}
