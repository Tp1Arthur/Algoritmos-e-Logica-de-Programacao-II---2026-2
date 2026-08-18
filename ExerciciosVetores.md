# Exercícios de Vetores em C# - IFRO

Os 3 exercícios estavam misturados dentro do mesmo `Main`. A divisão correta é:

* **Exercício 1:** preencher e imprimir um vetor.
* **Exercício 2:** preencher um vetor e calcular a soma.
* **Exercício 3:** preencher um vetor e encontrar o maior e o menor valor.

> **Observação:** o exercício 2 não pede média, e o exercício 3 não pede soma. Portanto, essas partes devem ser removidas para seguir exatamente os enunciados.

---

## Exercício 1 — Criando um vetor de inteiros

**Enunciado:**
Escreva um programa que crie um vetor de 5 inteiros, permita ao usuário preencher o vetor e depois exiba os valores na tela.

```csharp
using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 5;
            int[] vetor_inteiros = new int[tam];

            PreencherVetor(vetor_inteiros, tam);
            ImprimirVetor(vetor_inteiros, tam);
        }

        public static void PreencherVetor(int[] vetor, int tamanho)
        {
            Console.WriteLine($"Preenchendo o Vetor com {tamanho} numeros");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Informe o {i + 1}° numero: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void ImprimirVetor(int[] vetor, int tamanho)
        {
            Console.WriteLine("Exibindo os valores na Tela:");

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"O {i + 1}° valor foi {vetor[i]}");
            }
        }
    }
}
```

---

## Exercício 2 — Soma de elementos do vetor

**Enunciado:**
Crie um programa que solicite ao usuário 10 números inteiros, armazene-os em um vetor e calcule a soma de todos os elementos.

```csharp
using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            PreencherVetor(vetor, 10);

            int soma = SomarVetor(vetor, 10);

            Console.WriteLine($"A soma dos valores no vetor é {soma}");
        }

        public static void PreencherVetor(int[] vetor, int tamanho)
        {
            Console.WriteLine($"Preenchendo o Vetor com {tamanho} numeros");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Informe o {i + 1}° numero: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static int SomarVetor(int[] vetor, int tamanho)
        {
            int soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                soma = soma + vetor[i];
            }

            return soma;
        }
    }
}
```

---

## Exercício 3 — Maior e menor valor

**Enunciado:**
Crie um programa que leia 5 números inteiros, armazene-os em um vetor e depois analise o vetor preenchido e determine o maior e o menor valor.

```csharp
using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero_inteiros = new int[5];

            PreencherVetor(numero_inteiros, 5);

            EncontrarMaiorMenor(numero_inteiros, 5);
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
            Console.WriteLine($"O menor número encontrado foi {menor}");
        }

        public static void PreencherVetor(int[] vetor, int tamanho)
        {
            Console.WriteLine($"Preenchendo o Vetor com {tamanho} numeros");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Informe o {i + 1}° numero: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

```
