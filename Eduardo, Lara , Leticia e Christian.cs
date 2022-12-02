using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3, palavra4, palavra5, OK, palavrachave = "Gado", palavra = "", palavra11, palavra12, palavra13, palavra14, palavra15, palavrachave1 = "Gado1", proximo;
            int seletor, tentativas = 0, seletor1, tentativas1 = 0;


            Console.WriteLine("ADIVINHADOR");
            Console.WriteLine("REGRAS:");
            Console.WriteLine("*TENTE DESCOBRIR A PALAVRA SECRETA COM O MENOR NÚMERO DE TENTATIVAS");
            Console.WriteLine("Escreva OK para Continuar");
            OK = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Jogador 1");
            Console.WriteLine("Digite a primeira palavra");
            palavra1 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a segunda palavra");
            palavra2 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a terceira palavra");
            palavra3 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a quarta palavra");
            palavra4 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a quinta palavra");
            palavra5 = Console.ReadLine();



            Random adivinhador = new Random();
            seletor = adivinhador.Next(4);



            if (seletor == 0)
            {
                palavrachave = palavra1;
                Console.ReadKey();
            }
            else if (seletor == 1)
            {
                palavrachave = palavra2;
                Console.ReadKey();
            }
            else if (seletor == 2)
            {
                palavrachave = palavra3;
                Console.ReadKey();
            }
            else if (seletor == 3)
            {
                palavrachave = palavra4;
                Console.ReadKey();
            }
            else if (seletor == 4)
            {
                palavrachave = palavra5;
                Console.ReadKey();
            }


            do
            {

                Console.Clear();
                Console.WriteLine("Tente advinhar a palavra chave");
                palavra = Console.ReadLine();
                tentativas = tentativas + 1;
                Console.Clear();
                Console.ReadKey();


            } while (palavra == palavrachave);


            Console.WriteLine("Você adivinhou a palavra chave em "
            + tentativas + " tentativas");


            Console.WriteLine("Próximo Jogador");
            proximo = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Jogador 2");
            Console.WriteLine("Digite a primeira palavra");
            palavra11 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a segunda palavra");
            palavra12 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a terceira palavra");
            palavra13 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a quarta palavra");
            palavra14 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Digite a quinta palavra");
            palavra15 = Console.ReadLine();



            Random adivinhador1 = new Random();
            seletor1 = adivinhador1.Next(4);




            if (seletor1 == 0)
            {
                palavrachave1 = palavra11;
                Console.ReadKey();
            }
            else if (seletor1 == 1)
            {
                palavrachave1 = palavra12;
                Console.ReadKey();
            }
            else if (seletor1 == 2)
            {
                palavrachave1 = palavra13;
                Console.ReadKey();
            }
            else if (seletor1 == 3)
            {
                palavrachave1 = palavra14;
                Console.ReadKey();
            }
            else if (seletor1 == 4)
            {
                palavrachave1 = palavra15;
                Console.ReadKey();
            }


            do
            {

                Console.Clear();
                Console.WriteLine("tente advinhar a palavra chave");
                palavra1 = Console.ReadLine();
                tentativas1 = tentativas1 + 1;
                Console.Clear();


            } while (palavra1 == palavrachave1);


            Console.WriteLine("Você adivinhou a palavra chave em "
            + tentativas1 + " tentativas");


            if (tentativas < tentativas1)
            {
                Console.WriteLine("Jogador 2 ganhou");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Jogador 1 ganhou");
                Console.ReadKey();
            }


            Console.ReadKey();
        }
    }
}
