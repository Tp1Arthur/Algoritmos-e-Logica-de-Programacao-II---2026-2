### 1. Criando um vetor de inteiros

Escreva um programa que crie um vetor de 5 inteiros, permita ao usuário preencher o
vetor e depois exiba os valores na tela.

**Resposta:**

```csharp

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite o " + i + " numero: ");
            numeros[i]= Convert.ToInt32(Console.ReadLine());
        }
        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }
        
    }
}
```

### 2. Soma de elementos do vetor
Crie um programa que solicite ao usuário 10 números inteiros, armazene-os em um vetor
e calcule a soma de todos os elementos.

**Resposta:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite o " + i + " numero: ");
            numeros[i]= Convert.ToInt32(Console.ReadLine());
            soma = soma + numeros[i];
        }
        Console.WriteLine(soma);
        
    }
}
```

### 3. Maior e menor valor
Crie um programa que leia 5 números inteiros, armazene-os em um vetor e depois analise
o vetor preenchido e determine o maior e o menor valor.

**Resposta:**

```csharp
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite o " + i + " numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maior = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
            else if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
    }
}
```

### 4. Média dos valores
Faça um programa que leia 8 números inteiros, armazene-os em um vetor e calcule a
média dos valores.

**Resposta:**
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[8];
            double soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite o " + i + " numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                soma = soma + numeros[i];
            }

            double resultado = soma / 8;

            Console.WriteLine("Resultado: " +  resultado);
        }
    }
}
```

### 5. Elementos pares e ímpares
Escreva um programa que leia 10 números inteiros e armazene-os em um vetor. Ao final,
leia o vetor e mostre quantos são pares e quantos são ímpares.

**Resposta:**
```csharp
```

### 6. Invertendo a ordem dos elementos
Crie um programa que leia 6 números inteiros e armazene-os em um vetor. Depois, exiba
os números na ordem inversa da inserida.

**Resposta:**
```csharp
```

### 7. Contagem de números positivos e negativos
Faça um programa que leia 10 números, armazene-os em um vetor e conte quantos são
positivos e quantos são negativos.

**Resposta:**
```csharp
```

### 8. Multiplicação por constante
Escreva um programa que leia 5 números e armazene-os em um vetor. Depois, peça ao
usuário um número constante e multiplique todos os elementos do vetor por esse número,
mostrando o resultado.

**Resposta:**
```csharp
```

### 9. Elementos acima da média
Faça um programa que leia 7 números inteiros e armazene-os em um vetor. Calcule a
média e mostre quais números são maiores que a média.

**Resposta:**
```csharp
```

### 10. Contando ocorrências de um número
Crie um programa que leia 10 números inteiros e armazene-os em um vetor. Em seguida,
peça ao usuário para inserir um número e informe quantas vezes esse número aparece no
vetor.

**Resposta:**
```csharp
```

### 11. Quadrado dos elementos
Crie um programa que leia 5 números inteiros e armazene-os em um vetor. Depois,
calcule o quadrado de cada elemento e exiba os resultados.

**Resposta:**
```csharp
```

### 12. Soma dos pares
Faça um programa que leia 8 números inteiros e armazene-os em um vetor. Ao final, some
todos os números pares e exiba o resultado.

**Resposta:**
```csharp
```

### 13. Pesquisa de valor
Crie um programa que leia 10 números inteiros, armazene-os em um vetor e depois
permita ao usuário buscar por um número. O programa deve informar se o número está
ou não no vetor.

**Resposta:**
```csharp
```

### 14. Substituindo elementos negativos
Faça um programa que leia 10 números e armazene-os em um vetor. Substitua os valores
negativos por 0 e exiba o vetor modificado.

**Resposta:**
```csharp
```

### 15. Somando dois vetores
Crie um programa que solicite ao usuário dois vetores de 5 números inteiros cada. O
programa deve somar os elementos correspondentes dos dois vetores e exibir o vetor
resultante.

**Resposta:**
```csharp
```
