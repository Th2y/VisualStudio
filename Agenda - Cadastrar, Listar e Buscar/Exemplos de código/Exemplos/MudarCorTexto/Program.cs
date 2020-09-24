using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudarCorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Este texto é azul");
            Console.WriteLine("Este texto também é azul");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Verde");
            Console.ReadKey();
        }
    }
}
