using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.E._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Número = " + i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int Snumeros = numeros.Sum();
            Console.WriteLine("A soma dos números é: " + Snumeros);

            double Mnumeros = numeros.Average();
            Console.WriteLine("A média dos números é: " + Mnumeros);

            Console.ReadKey();
        }
    }
}








