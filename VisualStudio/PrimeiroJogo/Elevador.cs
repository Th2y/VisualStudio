using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    class Elevador
    {
        // Quantidade de pessoas dentro do elevador
        private int quantidadePessoas;
        private int andarAtual;

        private int maximoPessoas;
        private int quantidadeAndares;


        public Elevador(int quantidadeAndares, int maximoPessoas)
        {
            this.quantidadeAndares = quantidadeAndares;
            this.maximoPessoas = maximoPessoas;
            this.quantidadePessoas = 0;
            this.andarAtual = 1;
        }

        public int QuantidadePessoas
        {
            get
            {
                return this.quantidadePessoas;
            }
            set
            {
                if (value <= maximoPessoas)
                {
                    if (value >= 0)
                    {
                        this.quantidadePessoas = value;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nElevador já está vazio.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nElevador lotado.");
                    Console.ResetColor();
                }
            }
        }

        public int AndarAtual
        {
            get
            {
                return this.andarAtual;
            }
            set
            {
                if (value <= this.quantidadeAndares)
                {
                    if (value >= 1)
                    {
                        this.andarAtual = value;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nO elevador não pode descer mais.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nO elevador não pode subir mais.");
                    Console.ResetColor();
                }
            }
        }

        public void Entra()
        {
            int pessoas = QuantidadePessoas;
            // Adiciona uma pessoa
            QuantidadePessoas++;

            if (pessoas < QuantidadePessoas)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nUma pessoa entrou no elevador.");
                Console.ResetColor();
            }
        }
        public void Sai()
        {
            int pessoas = QuantidadePessoas;
            // Remove uma pessoa
            QuantidadePessoas--;

            if (pessoas > QuantidadePessoas)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nUma pessoa saiu do elevador.");
                Console.ResetColor();
            }
        }

        public void Sobe()
        {
            int andar = AndarAtual;
            // Sobe um andar
            AndarAtual++;

            if (andar < AndarAtual)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nO elevador subiu um andar.");
                Console.ResetColor();
            }
        }

        public void Desce()
        {
            int andar = AndarAtual;
            // Desce um andar
            AndarAtual--;

            if (andar > AndarAtual)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nO elevador desceu um andar.");
                Console.ResetColor();
            }
        }
    }
}
