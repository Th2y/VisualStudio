using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoverCaractereSemDeixarRastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int posicaoX = 0;
            int posicaoY = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(posicaoX, posicaoY);
            Console.Write("@");

            for (; ; )
            {
                ConsoleKeyInfo teclaPressiona = Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(posicaoX, posicaoY);
                Console.Write(" ");
                if (teclaPressiona.Key == ConsoleKey.UpArrow)
                {
                    posicaoY--;
                }
                else
                {
                    if (teclaPressiona.Key == ConsoleKey.DownArrow)
                    {
                        posicaoY++;
                    }
                    else
                    {
                        if (teclaPressiona.Key == ConsoleKey.LeftArrow)
                        {
                            posicaoX--;
                        }
                        else
                        {
                            if (teclaPressiona.Key == ConsoleKey.RightArrow)
                            {
                                posicaoX++;
                            }
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(posicaoX, posicaoY);
                Console.Write("@");
            }
        }
    }
}
