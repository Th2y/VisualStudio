using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoverCursor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 15);
            Console.Write("Texto escrito a partir da posição x=10, y=15");            
            Console.ReadKey();
        }
    }
}
