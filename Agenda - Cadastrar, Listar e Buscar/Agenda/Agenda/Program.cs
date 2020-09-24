using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            do
            {
                Console.WriteLine("**** Agenda ****");
                Console.WriteLine();
                Console.WriteLine("1) Cadastrar");
                Console.WriteLine("2) Remover");
                Console.WriteLine("3) Buscar");
                Console.WriteLine("4) Listar");
                Console.WriteLine();
                Console.Write("Opção..: ");


                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    // Cadastrar
                    Console.WriteLine("Digite as informações da pessoa");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    float altura = float.Parse(Console.ReadLine());

                    agenda.Cadastrar(nome, idade, altura);
                    agenda.Listar();
                }
                else if (opcao == 2)
                {
                    // Remover
                    Console.WriteLine("Digite as informações da pessoa");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    agenda.Remover(nome);
                }
                else if (opcao == 3)
                {
                    // Buscar
                    Console.WriteLine("Digite as informações da pessoa");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    agenda.Buscar(nome);
                }
                else if (opcao == 4)
                {
                    // Listar
                    agenda.Listar();
                }

            } while (true);
        }
    }
}
