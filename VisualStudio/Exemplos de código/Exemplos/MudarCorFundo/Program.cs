using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudarCorFundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreve 10 "espaços" na cor azul
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int contador = 0; contador < 10; contador++)
            {
                Console.Write(" ");
            }

            // Escreve 10 "espaços" na cor vermelha
            Console.BackgroundColor = ConsoleColor.Red;
            for (int contador = 0; contador < 10; contador++)
            {
                Console.Write(" ");
            }

            // Escreve 10 "espaços" na cor amarela
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int contador = 0; contador < 10; contador++)
            {
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
