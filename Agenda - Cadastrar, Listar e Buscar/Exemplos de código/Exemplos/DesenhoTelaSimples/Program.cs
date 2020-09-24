using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenhoTelaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura = Console.WindowWidth;
            int altura = Console.WindowHeight;
            
            // Desenha a linha superior
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < largura; i++)
            {
                // Caso esteja no canto esquerdo
                // ou no canto direito da tela
                if ((i == 0) | (i == (largura - 1)))
                {
                    // Desenha um "+"
                    Console.Write("+");
                }
                else
                {
                    // Desenha um "-" em qualquer outra posição
                    // que não seja nos cantos da tela
                    Console.Write("-");
                }
            }

            // Desenha a linha inferior
            Console.SetCursorPosition(0, (altura - 2));
            for (int i = 0; i < largura; i++)
            {
                // Caso esteja no canto esquerdo
                // ou no canto direito da tela
                if ((i == 0) | (i == (largura - 1)))
                {
                    // Desenha um "+"
                    Console.Write("+");
                }
                else
                {
                    // Desenha um "-" em qualquer outra posição
                    // que não seja nos cantos da tela
                    Console.Write("-");
                }
            }

            // Desenha as barras laterais
            for (int i = 1; i < (altura - 2); i++)
            {
                // Move o cursos para a lateral esquerda (eixo X)
                // na linha identificada pela variávei "i"
                Console.SetCursorPosition(0, i);
                Console.Write("|");

                // Move o cursos para a lateral direita (eixo X)
                // na linha identificada pela variávei "i"
                Console.SetCursorPosition((largura - 1), i);
                Console.Write("|");
            }

            // Desenha a linha horizontal que divide
            // a tela em duas partes
            Console.SetCursorPosition(0, (altura - 8));
            for (int i = 0; i < largura; i++)
            {
                // Caso esteja no canto esquerdo
                // ou no canto direito da tela
                if ((i == 0) | (i == (largura - 1)))
                {
                    // Desenha um "+"
                    Console.Write("+");
                }
                else
                {
                    // Desenha um "-" em qualquer outra posição
                    // que não seja nos cantos da tela
                    Console.Write("-");
                }
            }


            Console.ReadKey();
        }
    }
}
