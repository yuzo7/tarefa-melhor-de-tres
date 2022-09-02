using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, jogada, vitoriasjogador=0, vitoriasmaquina=0;

            do { 

            Console.WriteLine("Melhor de três");
            Console.WriteLine("1-PEDRA");
            Console.WriteLine("2-PAPEL");
            Console.WriteLine("3-TESOURA");


           opcao = Convert.ToInt32(Console.ReadLine());

            Random jokenpo = new Random();
            jogada = jokenpo.Next(2);

            // 0 -> PEDRA
            // 1 -> PAPEL
            // 2 -> TESOURA

            if (opcao == 0 && jogada == 0)
            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PEDRA");
                Console.WriteLine("EMPATE!");
            }

            else if (opcao == 0 && jogada == 1)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PAPEL");
                Console.WriteLine("O COMPUTADOR GANHOU!");
                vitoriasmaquina = vitoriasmaquina + 1;
            }
                else if (opcao == 0 && jogada == 2)
            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU TESOURA");
                Console.WriteLine("JOGADOR VENCEU!");
                vitoriasjogador = vitoriasjogador + 1;
            }

            else if (opcao == 1 && jogada == 0)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PEDRA!");
                Console.WriteLine("JOGADOR VENCEU!");
                vitoriasjogador = vitoriasjogador + 1;
            }

            else if (opcao == 1 && jogada == 1)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PAPEL!");
                Console.WriteLine("JOGADOR VENCEU!");
                vitoriasjogador = vitoriasjogador + 1;
            }

            else if (opcao == 1 && jogada == 1)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PAPEL");
                Console.WriteLine("JOGADOR VENCEU!");
                    vitoriasjogador = vitoriasjogador + 1;
            }
            else if (opcao == 1 && jogada == 2)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU TESOURA");
                Console.WriteLine("COMPUTADOR VENCEU!");
                vitoriasmaquina = vitoriasmaquina + 1;
                }
            else if (opcao == 2 && jogada == 0)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PEDRA");
                Console.WriteLine("COMPUTADOR VENCEU!");
                vitoriasmaquina = vitoriasmaquina + 1;
                }
            else if (opcao == 2 && jogada == 1)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU PAPEL");
                Console.WriteLine("JOGADOR VENCEU!");
                    vitoriasjogador = vitoriasjogador + 1;
            }
            else if (opcao == 2 && jogada == 2)

            {
                Console.Clear();
                Console.WriteLine("A MAQUINA JOGOU TESOURA");
                Console.WriteLine("EMPATE!");
            }
            }while(vitoriasjogador + vitoriasmaquina <3);

           
            if (vitoriasjogador > vitoriasmaquina)
            {
                Console.WriteLine("Jogador Venceu");
            }
            else
            {
                Console.WriteLine("Jogador perdeu");
            }
            Console.WriteLine("jogador fez:" + ""+ vitoriasjogador+"pontos");
            Console.WriteLine("maquina fez:" + ""+vitoriasmaquina+"pontos");


            Console.ReadKey();






        }
}
}
