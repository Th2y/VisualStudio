using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PararExecucaoPorAlgunsSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {                
                Console.WriteLine(i);
                // Para a execução do programa por "x" millisegundos
                // 0,25 segundos = 250
                // 0,5 segundos = 500
                // 1 segundo = 1000
                // 10 segundos = 10000
                int tempoDePausa = 250;
                System.Threading.Thread.Sleep(tempoDePausa);
            }
            Console.ReadKey();
        }
    }
}
