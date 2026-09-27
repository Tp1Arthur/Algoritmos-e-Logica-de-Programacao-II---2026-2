<div align="center">
  
#  LÓGICA DE PROGRAMAÇÃO - Loteria Matrix (Matrizes e Listas)

</div>


**Objetivo:** Desenvolver o raciocínio lógico avançado e a modularização de código utilizando Listas dinâmicas, Matrizes (Arrays 2D), laços de repetição, geração de números aleatórios e validação de regras de negócio.

**Cenário:**

Você foi contratado por uma casa de apostas para desenvolver o protótipo de um novo jogo de loteria de terminal chamado **"Matrix-9"**.

Neste jogo, um "Bilhete" de aposta pode conter vários "Jogos".

- Cada "Jogo" é uma **Matriz 3x3** (9 números).
- Os números permitidos vão de **1 até 30**.
- **Regra de Ouro:** Não podem existir números repetidos dentro do mesmo jogo de 9 números!

Sua tarefa é construir o sistema de console que permita ao usuário criar seu bilhete, gerar jogos automáticos e, ao final, sortear e conferir os resultados.

## Requisitos do Sistema

O programa deve possuir um Menu Interativo com as seguintes opções (usando switch-case):

### 1. Criar Jogo Manual

- O sistema cria uma matriz 3x3.
- Utiliza laços aninhados para pedir ao usuário que digite os 9 números.
- **Validação 1:** O número deve estar entre 1 e 30.
- **Validação 2:** O número não pode já ter sido digitado neste mesmo jogo. (Dica: crie uma função auxiliar booleana `ExisteNaMatriz(matriz, numero)` para ajudar nisso).
- Se passar nas validações, insere na matriz. Ao final dos 9 números, adiciona a matriz à Lista do bilhete.

### 2. Gerar Múltiplos Jogos Aleatórios (Surpresinha)

- O sistema deve perguntar: *"Quantos jogos aleatórios você quer gerar?"*
- Para cada jogo solicitado, gere uma matriz 3x3 preenchida com números aleatórios (usando a classe Random).
- **Atenção:** As mesmas regras se aplicam! O número sorteado para a matriz deve ser de 1 a 30 e não pode estar repetido dentro do próprio jogo.

### 3. Visualizar Bilhete de Apostas

- Percorra a Lista de jogos.
- Imprima cada jogo (matriz 3x3) na tela no formato de um grid (tabela), indicando o número do jogo (ex: `--- Jogo 1 ---`).

### 4. Sortear e Conferir Bilhete

- O sistema deve realizar o "Sorteio Oficial": gerar **9 números aleatórios únicos** (sem repetição) de 1 a 30.
- Imprima os 9 números sorteados na tela.
- Em seguida, percorra a lista de jogos do usuário. Para cada matriz, verifique quantos números coincidem com os números sorteados.
- Imprima o resultado de cada jogo (ex: `Jogo 1: 4 acertos!`).

### 0. Sair

- Encerra a execução.



# CODIGO:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMatrizes01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            int opc = 0;

            List<int[,]> bilhete = new List<int[,]>();

            do
            {
                Console.WriteLine("##########################################");
                Console.WriteLine("############# ++ Matrix-9 ++ #############");
                Console.WriteLine("##########################################");
                Console.WriteLine("1. Criar Jogo Manual");
                Console.WriteLine("2. Gerar Multiplos Jogos Aleatorios");
                Console.WriteLine("3. Visualizar Bilhete de Apostas");
                Console.WriteLine("4. Sortear e Conferir Bilhete");
                Console.WriteLine("0. Sair");
                Console.WriteLine("  ");
                Console.Write("Digite uma Opcao: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                    {
                        int[,] jogo = CriarJogoManual();

                        bilhete.Add(jogo);

                        Console.WriteLine("Jogo adicionado ao bilhete!");
                        break;
                    }

                    case 2:
                    {
                        Console.Write("Quantos jogos aleatorios voce quer gerar? ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < quantidade; i++)
                        {
                            int[,] jogo = GerarJogoAleatorio();

                            bilhete.Add(jogo);
                        }

                        Console.WriteLine($"{quantidade} jogo(s) adicionado(s) ao bilhete!");
                        break;
                    }

                    case 3:
                    {
                        VisualizarBilhete(bilhete);
                        break;
                    }

                    case 4:
                    {
                        SortearEConferir(bilhete);
                        break;
                    }

                    case 0:
                    {
                        Console.WriteLine("Saindo...");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("ERRO!!!");
                        break;
                    }
                }

            } while (opc != 0);
        }


        public static int[,] CriarJogoManual()
        {
            int[,] jogo = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int numero;

                    do
                    {
                        Console.Write($"Digite o numero da posicao [{i},{j}]: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero < 1 || numero > 30 || ExisteNaMatriz(numero, jogo))
                        {
                            Console.WriteLine("Numero inválido! Digite um valor entre 1 e 30 e que ainda nao foi utilizado.");
                        }

                    } while (numero < 1 || numero > 30 || ExisteNaMatriz(numero, jogo));

                    jogo[i, j] = numero;
                }
            }

            return jogo;
        }


        public static bool ExisteNaMatriz(int numero, int[,] matriz)
        {
            bool achou = false;

            foreach (int elemento in matriz)
            {
                if (numero == elemento)
                    achou = true;
            }

            return achou;
        }


        public static int[,] GerarJogoAleatorio()
        {
            int[,] jogo = new int[3, 3];

            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int numero;

                    do
                    {
                        numero = r.Next(1, 31);

                    } while (ExisteNaMatriz(numero, jogo));

                    jogo[i, j] = numero;
                }
            }

            return jogo;
        }


        public static void VisualizarBilhete(List<int[,]> bilhete)
        {
            if (bilhete.Count == 0)
            {
                Console.WriteLine("O bilhete esta vazio!");
                return;
            }

            Console.WriteLine("\n##########################################");
            Console.WriteLine("########## BILHETE DE APOSTAS ###########");
            Console.WriteLine("##########################################");

            for (int k = 0; k < bilhete.Count; k++)
            {
                Console.WriteLine($"\n--- Jogo {k + 1} ---");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{bilhete[k][i, j],2} | ");
                    }

                    Console.WriteLine();
                }
            }
        }


        public static int[,] SortearNumeros()
        {
            int[,] sorteio = new int[3, 3];

            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int numero;

                    do
                    {
                        numero = r.Next(1, 31);

                    } while (ExisteNaMatriz(numero, sorteio));

                    sorteio[i, j] = numero;
                }
            }

            return sorteio;
        }


        public static void SortearEConferir(List<int[,]> bilhete)
        {
            if (bilhete.Count == 0)
            {
                Console.WriteLine("O bilhete esta vazio!");
                return;
            }

            int[,] sorteio = SortearNumeros();

            Console.WriteLine("\n##########################################");
            Console.WriteLine("########### SORTEIO OFICIAL #############");
            Console.WriteLine("##########################################");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{sorteio[i, j],2} | ");
                }

                Console.WriteLine();
            }


            Console.WriteLine("\n########### RESULTADOS ##################");

            for (int k = 0; k < bilhete.Count; k++)
            {
                int acertos = 0;

                foreach (int elemento in bilhete[k])
                {
                    if (ExisteNaMatriz(elemento, sorteio))
                    {
                        acertos++;
                    }
                }

                Console.WriteLine($"Jogo {k + 1}: {acertos} acertos!");
            }
        }
    }
}

```
