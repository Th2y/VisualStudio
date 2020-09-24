using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificarTeclaPressionada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtém as informações da tecla pressionada
            // mas não exibe na tela 
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            Console.WriteLine("A tecla pressionada foi: " + keyInfo.Key);
            Console.ReadKey();
        }
    }
}
