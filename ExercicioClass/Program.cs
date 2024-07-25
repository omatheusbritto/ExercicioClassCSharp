// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha
using ExercicioClass;
using System;
using System.Globalization;

namespace ExercicioCriacaoDeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas s1, s2;

            s1 = new Pessoas();
            s2 = new Pessoas();

            Console.Write("Digite o nome: ");
            s1.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            s1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o nome: ");
            s2.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            s2.Idade = int.Parse(Console.ReadLine());

            if (s1.Idade > s2.Idade)
            {
                Console.WriteLine("{0} que tem {1} anos tem mais idade!", s1.Nome, s1.Idade);
            }
            else
            {
                Console.WriteLine("{0} que tem {1} anos tem mais idade!", s2.Nome, s2.Idade);

            }
        }
    }
}

