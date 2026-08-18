using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula170825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor_inteiros = new int[5];

            Console.WriteLine("Preenchendo.....");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"informe o {i+1}° numero: ");
                vetor_inteiros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Exibindo os valores na Tela: ");
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine($"O {i+1}° valor digitado foi {vetor_inteiros [i]}");
            }
            /*exercicio 1
            int tam = 5
            int[] vetor_inteiros = new int[tam];
            PreencherVetor(vetor_inteiros, tam);
            ImprimirVetor(vetor_inteiroos, tam);
            */

            /*Exercicio 2
            int[] vetor = new int[10];
            PreencherVetor(vetor, 10);
            Console.WriteLine($"A soma dos valores no vetor é {SomarVetor(vetor, 10)}");
            double media = SomarVetor(vetor, 10) / 10;
            */

            //Exercicio 3
            int[] numero_inteiros = new int[5];
            PreencherVetor(numero_inteiros, 5);
            EncontrarMaiorMenor(numero_inteiros, 5);
            Console.WriteLine($"A soma dos numeros é {SomarVetor(numero_inteiros, 5)}");




        }

        public static void EncontrarMaiorMenor(int[] vetor, int tamanho)
        {
            int maior = vetor[0];
            int menor = vetor[0];

            for (int i = 0; i < tamanho; i++)
            {
                if (maior < vetor[i])
                    maior = vetor[i];

                if (menor > vetor[i])
                    menor = vetor[i];
            }

            Console.WriteLine($"O maior número encontrado foi {maior}");
            Console.WriteLine($"O menor numero encontrado foi {menor}");
        }


        public static int SomarVetor(int[] vetor, int tamanho)
        {
            int soma = 0;
            for (int i = 0; i <= tamanho; i++)
            {
                soma = soma + vetor[i];
            }

            return soma;
        }

        public static void ImprimirVetor(int[] vetor, int tamanho)
        {
            Console.WriteLine("Exibindo os valores na Tela: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"O {i + 1}° valor  foi {vetor[i]}");
            }
        }

        public static void PreencherVetor(int[] vetor, int tamanho)
        {
            Console.WriteLine($"Preenchendo o Vetor com {tamanho} numeros");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"informe o {i + 1}° numero: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
