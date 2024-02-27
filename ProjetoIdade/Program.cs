using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade em anos: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade em meses: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade em dias: ");
            int d = int.Parse(Console.ReadLine());

            int resultado = (a * 365) + (m * 30) + d;

            Console.WriteLine("Total de dias vividos: " + resultado);

            Console.ReadKey();

        }
    }
}
