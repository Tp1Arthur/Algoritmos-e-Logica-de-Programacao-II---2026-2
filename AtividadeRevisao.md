### 1. Anotar 5 nomes e visualizar os nomes

```csharp
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }

        Console.WriteLine("\n=== Nomes digitados ===");
        foreach (string n in nomes)
        {
            Console.WriteLine(n);
        }
    }
}                                                                                                                       
```

### 2. Peça nomes até o usuário digitar fim. Se o nome já estiver na lista, mostre “Nome já cadastrado” e não adicione
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        string resp = "";
        int i = 1;

        do
        {
            Console.Write($"Escreva o {i}º nome: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);

            Console.Write("Digite 'fim' para finalizar ou 'continuar': ");
            resp = Console.ReadLine();

            i++;
        } while (resp != "fim");

        Console.WriteLine("\n=== Nomes digitados ===");
        foreach (string n in nomes)
        {
            Console.WriteLine(n);
        }
    }
}
```
