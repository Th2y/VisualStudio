using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = Console.LargestWindowHeight;

            int delay = 50;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Thread.Sleep(delay);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" _______                            _______  __                                     ");
            Thread.Sleep(delay);
            Console.WriteLine("|   |   |.---.-..----..----..--.--.|     __||  |_ .----..---.-..-----..-----..-----.");
            Thread.Sleep(delay);
            Console.WriteLine("|       || _ || _ || _ ||  |  || __ || _ || _ || _ ||     || _ || -__ | ");
            Thread.Sleep(delay);
            Console.WriteLine("|___|___||___._||__|  |__|  |___  ||_______||____||__|  |___._||__|__||___  ||_____|");
            Thread.Sleep(delay);
            Console.WriteLine("                            |_____|                                   |_____|       ");
            Console.WriteLine("❤️");



            Thread.Sleep(delay);

            Console.CursorVisible = true;
            
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Informações do elevador");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Quantidade máxima de andares: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int quantidadeAndares = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Quantidade máxima de pessoas: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int maximoPessoas = int.Parse(Console.ReadLine());

            Elevador elevador = new Elevador(quantidadeAndares, maximoPessoas);

            string[] opcoes = new string[] { "Entrar", "Sair", "Subir", "Descer" };
            int opcao = 0;
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                // Quantidade de pessoas no elevador
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Quantidade atual de pessoa: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(elevador.QuantidadePessoas);

                // Andar atual do elevador
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Andar atual: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(elevador.AndarAtual);
                Console.WriteLine(); // Pula uma linha no console
                Console.WriteLine();
                Console.WriteLine();

                // Opções do menu
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Utilizando as ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("SETAS");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(", selecione uma das opções abaixo:");
                Console.WriteLine();

                for (int i = 0; i < opcoes.Length; i++)
                {
                    if (opcao == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("[ ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(opcoes[i]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" ]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(opcoes[i]);
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleKeyInfo keyInfo = Console.ReadKey(false);
                Console.ResetColor();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (opcao > 0)
                    {
                        opcao--;
                    }
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        if (opcao < (opcoes.Length - 1))
                        {
                            opcao++;
                        }
                    }
                    else
                    {
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            switch (opcao)
                            {
                                case 0:
                                    elevador.Entra();
                                    break;
                                case 1:
                                    elevador.Sai();
                                    break;
                                case 2:
                                    elevador.Sobe();
                                    break;
                                case 3:
                                    elevador.Desce();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n\nOpção inválida.");
                                    Console.ResetColor();
                                    break;
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}
