using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listapr2__10
{
    internal class Program
    {
        public static void Exercico1()
        {
            Console.WriteLine("aqui esta codificado o exercicio 1");

            Console.Write("Digite a quantidade de números: ");
            int n = int.Parse(Console.ReadLine());

            float[] numeros = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            float menor = numeros[0];
            float maior = numeros[0];
            float soma = numeros[0];

            for (int i = 1; i < n; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                soma += numeros[i];
            }

            float media = soma / n;

            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Maior número: {maior}");
            Console.WriteLine($"Média aritmética: {media}");

        }
        public static void Exercico2()
        {
            Console.WriteLine("aqui esta codificado o exercicio 2");

            Console.Write("Digite o tam do vetor: ");
            int p = int.Parse(Console.ReadLine());

            while (p <= 0)
            {
                Console.WriteLine("O tam do vetor precisa ser maior que zero. Tente novamente!");
                Console.Write("Digite o tam do vetor: ");
                p = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[p];

            for (int o = 0; o < p; o++)
            {
                Console.Write("Digite o número {0}: ", o + 1);
                vetor[o] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            for (int o = 0; o < p; o++)
            {
                soma += vetor[o];
            }

            float media = soma / p;

            Console.WriteLine("\nNúmero maior ou igual à média:");

            for (int o = 0; o < p; o++)
            {
                if (vetor[o] >= media)
                {
                    Console.WriteLine(vetor[o]);
                }
            }
        }


        public static void Exercico3()
        {
            Console.WriteLine("aqui esta codificado o exercicio 3");

            Console.Write("Digite o tam do vetor: ");
            int p = int.Parse(Console.ReadLine());
            Random rand = new Random();

            while (p <= 0)
            {
                Console.WriteLine("O tam do vetor precisa ser maior que zero.");
                Console.Write("Digite o tama do vetor: ");
                p = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[p];

            for (int o = 0; o < p; o++)
            {

                vetor[o] = rand.Next(10, 50);

            }

            float soma = 0;

            for (int o = 0; o < p; o++)
            {
                soma += vetor[o];
            }

            float media = soma / p;

            Console.WriteLine("\nNúmeros maiores ou iguais à média:");

            for (int o = 0; o < p; o++)
            {
                if (vetor[o] >= media)
                {
                    Console.WriteLine(vetor[o]);
                }
            }
        }

        public static void Exercico4()
        {
            Console.WriteLine("aqui esta codificado o exercicio 4");


            Console.Write("Digite a quantidade de nomes: ");
            int n = int.Parse(Console.ReadLine());

            List<string> nomes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º nome: ");
                string nome = Console.ReadLine();
                nomes.Add(nome);
            }

            Console.WriteLine("Nomes em ordem reversa:");

            for (int i = nomes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }
        }


        public static void Exercico5()
        {
            Console.WriteLine("aqui esta codificado o exercicio 5");

        }
        static void Main(string[] args)
        {

            int opcao;

            do

            {
                Console.WriteLine("Escolha um exercicio: ");

                Console.WriteLine("================MENU=================");
                Console.WriteLine(" Para sair - digite 0");
                Console.WriteLine(" Para executar exercicio 1 - digite 1");
                Console.WriteLine(" Para executar exercicio 2 - digite 2");
                Console.WriteLine(" Para executar exercicio 3 - digite 3");
                Console.WriteLine(" Para executar exercicio 4 - digite 4");
                Console.WriteLine(" Para executar exercicio 5 - digite 5");
                Console.WriteLine("=====================================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Exercico1();
                        break;
                    case 2:

                        Exercico2();
                        break;
                    case 3:

                        Exercico3();
                        break;
                    case 4:

                        Exercico4();
                        break;
                    case 5:

                        Exercico5();
                        break;
                    default:

                        Console.WriteLine(" numero não é um exercicio valido");
                        break;


                }



            } while (opcao != 0);
        }

    }
}


   

