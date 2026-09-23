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

        }

        public static void menu()
        {
            int opc = 0;
            Console.WriteLine("##########################################");
            Console.WriteLine("############# ++ Matrix-9 ++ #############");
            Console.WriteLine("##########################################");
            Console.WriteLine("1. Criar Jogo Manual");
            Console.WriteLine("2. Gerar Múltiplos Jogos Aleatórios");
            Console.WriteLine("3. Visualizar Bilhete de Apostas");
            Console.WriteLine("4. Sortear e Conferir Bilhete");
            Console.WriteLine("0. Sair");
            Console.WriteLine("  ");
            Console.Write("Digite uma Opção");
            opc = Convert.ToInt32(Console.ReadLine());
        }
    }
}

```
