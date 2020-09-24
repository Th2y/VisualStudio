using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12_08_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = true;

            Console.WriteLine();
            Console.WriteLine("Informações do elevador");
            Console.WriteLine("-----------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Qual a quantidade máxima de andares: ");
            int quantidadeAndares = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade máxima de pessoas: ");
            int maximoPessoas = int.Parse(Console.ReadLine());

            Elevador elevador = new Elevador(quantidadeAndares, maximoPessoas);
            
            string[] opcoes = new string[] { "Entrar", "Sair", "Subir", "Descer" };
            int opcao = 0;
            Console.CursorVisible = false;
            while(true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Quantidade atual de pessoas: ");
                Console.WriteLine(elevador.QuantidadePessoas);

                Console.Write("Andar atual: ");
                Console.WriteLine(elevador.AndarAtual);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Utilizando as setas, selecione uma das opções abaixo:");
                Console.WriteLine();

                for (int i = 0; i < opcoes.Length; i++)
                {
                    if (opcao == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("[ ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(opcoes[i]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" ]");
                    } else
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
                } else
                {
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        if (opcao < (opcoes.Length - 1))
                        {
                            opcao++;
                        }
                    } else
                    {
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            switch(opcao)
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
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Pressione qualquer tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}