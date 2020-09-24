using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroJogoSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu sexo? H(homem), M(mulher), O(outro) ");
            string sexo = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("E, antes de começarmos, qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(nome + ", saiba que se continuar vai viver uma experiência de jogo textual totalmente nova, esse jogo não é para fracos, vou te dar 10 segundos para desistir");
            int Pausa = 10000;
            System.Threading.Thread.Sleep(Pausa);

            Console.WriteLine("");
            Console.WriteLine("Ainda está aí? Nossa, que coragem, então vamos lá");
            Console.WriteLine("Mas antes, uma intrução: digite apenas quando a frase terminar com ? Mesmo que ela tenha no meio, não é para responder, espere um pouco que o jogo continuará logo em seguida");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            int pausaTexto = 5000;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.Clear();

            if (sexo == "H" || sexo == "h")
            {
                    Console.WriteLine("Chegou agora, querido?");
            }
            else
            {
                if (sexo == "M" || sexo == "m" || sexo == "O" || sexo == "o")
                {
                        Console.WriteLine("Chegou agora, querida?");
                }
            }
            string resp = Console.ReadLine();

            Console.WriteLine("O que estava fazendo lá fora? Estava te esperando...");

            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Mas tudo bem, a comida já está quase pronta, está com fome? ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string fome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Ai, que fofura, você acha que eu me importo, vai comer de qualquer jeito");
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Só para não sermos injustos, o que gostaria de comer? ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string comida = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Black;
            if (comida == "Nada" || comida == "nada" || comida == "NADA")
            {
                Console.WriteLine(comida + "? Você não tem escolha, vai comer o que eu quiser então");
            }
            else
            {
                if(comida == "Pizza" || comida == "pizza" || comida =="PIZZA")
                {
                    Console.WriteLine(comida + "? Acertou em cheio! É isso mesmo que vamos comer, para um jantar tão maravilhoso quanto o lindo dia de amanhã");
                }
                else
                {
                    Console.WriteLine(comida + "? Mas que audácia pedir isso! Vamos comer o que eu quiser então ");
                    System.Threading.Thread.Sleep(pausaTexto);
                    Console.WriteLine("E, só para te informar, o que eu quero é pizza, para termos um jantar tão maravilhoso quanto o lindo dia de amanhã");
                    System.Threading.Thread.Sleep(pausaTexto);
                    Console.WriteLine("Gostou da minha ideia? ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    string ideia = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (ideia == "Sim" || ideia == "SIM" || ideia == "sim" || ideia == "S" || ideia == "s")
                    {
                        Console.WriteLine("Agora sim estamos voltando a nos enterder, continue assim");
                    }
                    else
                    {
                        Console.WriteLine("Assim não dá, vamos ter muito trabalho desse jeito! Eu só queria me entender com você!");
                        System.Threading.Thread.Sleep(pausaTexto);
                        Console.WriteLine("Mas não vou chorar nem brigar, não agora, vamos comer logo");
                    }
                }
            }

            System.Threading.Thread.Sleep(pausaTexto);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Senhores, a comida já está na mesa, do jeito como pediu");

            Console.ForegroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Certo, já estamos indo, já pode ir para a sua casa, precisamos ter um tempinho a sós");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Como preferir, vou apenas pegar minhas coisas e sair");

            Console.ForegroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Tudo bem, pode pegar suas coisas, e só volte daqui a uma semana, aproveite bem a folga, quando voltar poderá ter muito trabalho te esperando");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Sem problemas, qualquer coisa é só ligar");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Esperando ficarem a sós...");
            System.Threading.Thread.Sleep(Pausa);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Agora sim, quase tudo está perfeito, falta apenas você...");
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Não precisa ter medo, estou aqui e ninguém poderá te fazer mal antes de passar por mim, sou sua proteção");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Isso só me deixa com mais medo ainda, eu nem me lembro o motivo de estar aqui, muito menos com você");
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Quantas vezes vou ter que te pedir para se afastar de mim? EU NUNCA GOSTEI DE VOCÊ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Cale a boca! Você sempre me amou, desde o dia que nos vimos pela primeira vez");
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Vamos comer logo, ou eu vou ter que te machucar");

            System.Threading.Thread.Sleep(pausaTexto);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Baixe isso, você não quer fazer isso, deixe-me sair e tudo ficará bem, prometo não chamar a polícia nem te internar");

            System.Threading.Thread.Sleep(pausaTexto);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("NÃO! VOCÊ SÓ SABE MENTIR! Se eu te deixar sair, nunca mais te verei, então antes que isso aconteça, vá para a mesa, ou acertarei suas pernas");

            System.Threading.Thread.Sleep(pausaTexto);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Tudo bem, você venceu dessa vez, mas saiba que um dia vai perceber que não me ama, quem ama cuida do outro e quer ver feliz");
            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Eu te amo, e teríamos uma ótima amizade se não agisse assim sempre");

            System.Threading.Thread.Sleep(pausaTexto);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Eu não quero a sua amizade, não suportaria te ver com mais ninguém. Eu te amo, e nessa semana te farei me amar do mesmo jeito que eu te amo. Não fale nada e ande logo");

            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("A comida estava boa meu amor?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string boa = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Black;
            if (boa == "Sim" || boa == "SIM" || boa == "sim" || boa == "S" || boa == "s")
            {
                Console.WriteLine("Ótimo, agora vamos dormir");
            }
            else
            {
                Console.WriteLine("Amanhã resolvemos isso, agora vamos dormir");
            }

            System.Threading.Thread.Sleep(pausaTexto);
            Console.WriteLine("Onde você quer dormir?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string dormir = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(dormir + "? Nem pensar! Por garantia, vou dormir no nosso quarto e você no porão, lá tem tudo, menos saída, ficarei com a chave da porta");

            Console.ReadKey();
        }
    }
}
