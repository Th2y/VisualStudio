using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {

        Pessoa[] pessoas = new Pessoa[10];

        public void Cadastrar(string nome, int idade, float altura)
        {
            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i] == null)
                {
                    // Adicionar uma pessoa
                    Pessoa pessoa = new Pessoa(nome, idade, altura);
                    pessoas[i] = pessoa;
                    break;
                }
            }
        }

        public void Remover(string nome)
        {
            
        }

        public void Buscar(string nome)
        {
            for (int i = 0; i < this.pessoas.Length; i++)
            {
                if (pessoas[i] != null)
                {
                    if (pessoas[i].nome == nome)
                    {
                        Console.WriteLine(pessoas[i].nome + " " + pessoas[i].idade + " " + pessoas[i].altura);
                    }
                }
            }
        }

        public void Listar()
        {
            for (int i = 0; i < this.pessoas.Length; i++)
            {
                if (pessoas[i] != null)
                {
                    Console.WriteLine(pessoas[i].nome + " " + pessoas[i].idade + " " + pessoas[i].altura);
                }
            }
        }

    }
}
