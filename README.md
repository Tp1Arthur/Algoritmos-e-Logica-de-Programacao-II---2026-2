<div align="center">

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" width="80" height="80" alt="C#"/>
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dotnetcore/dotnetcore-original.svg" width="80" height="80" alt=".NET"/>
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/visualstudio/visualstudio-plain.svg" width="80" height="80" alt="Visual Studio"/>

<br><br>

# 🧩 Funções & Procedimentos em C#

### *Desvendando a Estrutura da Programação*

<sub>Lógica • Modularidade • Estruturas de Dados</sub>

<br>

<p>
  <img src="https://img.shields.io/badge/status-em%20andamento-yellow?style=flat-square" />
  <img src="https://img.shields.io/badge/licença-MIT-blue?style=flat-square" />
  <img src="https://img.shields.io/badge/nível-iniciante%2Fintermediário-success?style=flat-square" />
  <img src="https://img.shields.io/github/last-commit/Tp1Arthur/nome-do-repo?style=flat-square" />
</p>

<br>

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

</div>

<br>

> 💡 **Sobre este repositório**
> Material de estudo sobre **lógica de programação**, **modularidade** e **estruturas de dados** em C#, com foco em desenvolver raciocínio aplicado à solução de problemas computacionais.

<br>

<div align="center">

### 📖 Navegação Rápida

[🎯 Objetivo](#-objetivo) • [📑 Agenda](#-agenda) • [🏗️ Estrutura do Projeto](#️-estrutura-padrão-de-um-projeto-console-net-framework) • [🔧 Funções x Procedimentos](#-funções-vs-procedimentos) • [🔄 Parâmetros](#-passagem-de-parâmetros-valor-vs-referência) • [🧬 Sobrecarga](#-sobrecarga-de-funções-overloading) • [📝 Resumo](#-resumo) • [👤 Autor](#-autor)

</div>

<br>

<div align="center">

## ◆ 🎯 Objetivo ◆

</div>

Permitir que o aluno desenvolva o **raciocínio lógico** aplicado à solução de problemas em nível computacional, utilizando **estruturas de dados** em programação.

<div align="center">

<table>
<tr>
<td width="33%" align="center">
<br>📚<br><br>
<b>Compreender</b><br>
<sub>conceitos e definições das<br>estruturas de dados</sub>
<br><br>
</td>
<td width="33%" align="center">
<br>🧠<br><br>
<b>Resolver</b><br>
<sub>problemas estruturais<br>aplicando os conceitos</sub>
<br><br>
</td>
<td width="33%" align="center">
<br>💻<br><br>
<b>Desenvolver</b><br>
<sub>aplicações que utilizam<br>essas estruturas</sub>
<br><br>
</td>
</tr>
</table>

</div>

> 📌 **Atenção:** fique de olho também nas atividades da disciplina!

<br>

<div align="center">

## ◆ 📑 Agenda ◆

</div>

<div align="center">

| # | Tópico | Descrição |
|:-:|:--|:--|
| 1️⃣ | **Introdução e Objetivos** | Importância de funções e procedimentos para a modularidade do código |
| 2️⃣ | **Estrutura Padrão do Visual Studio** | Layout inicial de um projeto Console em C# |
| 3️⃣ | **Funções vs. Procedimentos** (`void`) | Diferenças, usos e quando aplicar cada um |
| 4️⃣ | **Exemplos Práticos** | Demonstrações de código para fixar o aprendizado |

</div>

<br>

<div align="center">

## ◆ 🏗️ Estrutura Padrão de um Projeto Console (.NET Framework) ◆

</div>

```csharp
using System;

namespace NomeDoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ponto de entrada da aplicação
        }
    }
}
```

<div align="center">

| Elemento | Função |
|:--|:--|
| `using System;` | Importa namespaces essenciais (ex: `System` para `Console`) |
| `namespace NomeDoProjeto` | Agrupa classes relacionadas e evita conflitos de nomes |
| `internal class Program` | Classe principal — ponto de entrada da aplicação |
| `static void Main(string[] args)` | Primeiro método executado ao iniciar o programa |

</div>

<br>

**✨ Por que usar `using`?**

<div align="center">

| 🔓 Acesso Simplificado | 🧩 Modularidade | ✨ Código Mais Limpo |
|:--|:--|:--|
| Usa classes de um namespace sem qualificação completa | Organiza o código em unidades lógicas reutilizáveis | Reduz verbosidade e melhora a legibilidade |

</div>

<br>

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

<br>

<div align="center">

## ◆ 🔧 Funções vs. Procedimentos ◆

</div>

<table>
<tr>
<th width="50%" align="center">🟢 Funções</th>
<th width="50%" align="center">🔵 Procedimentos (<code>void</code>)</th>
</tr>
<tr>
<td valign="top">

Executam uma tarefa e **retornam um valor**.

✔️ Tipo de retorno definido (`int`, `string`, `bool`...)
✔️ Podem receber parâmetros
✔️ Ideais para cálculos e transformações de dados

</td>
<td valign="top">

Executam ações mas **não retornam valor**.

✔️ Usam `void` como tipo de retorno
✔️ Podem receber parâmetros
✔️ Ideais para efeitos colaterais *(exibir dados, alterar variáveis...)*

</td>
</tr>
</table>

<br>

**🟢 Exemplo — Função**

```csharp
// Sem parâmetros
public static double CalcularMedia()
{
    double nota1 = 7.5, nota2 = 8.0, nota3 = 6.5;
    return (nota1 + nota2 + nota3) / 3;
}

// Com parâmetros
public static int Somar(int num1, int num2)
{
    return num1 + num2;
}
```

**🔵 Exemplo — Procedimento**

```csharp
// Sem parâmetros
public static void ExibirSaudacao()
{
    Console.WriteLine("Olá, bem-vindo(a)!");
}

// Com parâmetros
public static void ExibirMensagem(string nome)
{
    Console.WriteLine($"Olá, {nome}! Tenha um ótimo dia.");
}
```

<br>

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

<br>

<div align="center">

## ◆ 🔄 Passagem de Parâmetros: Valor vs. Referência ◆

</div>

<table>
<tr>
<th width="50%" align="center">📦 Por Valor</th>
<th width="50%" align="center">🔗 Por Referência (<code>ref</code> / <code>out</code>)</th>
</tr>
<tr>
<td valign="top">

Uma **cópia** da variável é enviada.
Alterações internas **não** afetam a original.

```csharp
public static void ModificarValor(int numero)
{
    numero = numero * 2;
}
// valorOriginal segue 10
```

</td>
<td valign="top">

A **referência de memória** é enviada.
Alterações internas **afetam** a original.

```csharp
public static void ModificarReferencia(ref int numero)
{
    numero = numero * 2;
}
// valorOriginal vira 20
```

</td>
</tr>
</table>

<div align="center">

| Tipo de Passagem | Padrão para |
|:-:|:-:|
| 📦 Por valor | `int`, `float`, `bool`, `char`, `structs` |
| 🔗 Por referência | `classes`, `arrays`, `strings` + uso explícito de `ref`/`out` |

</div>

<br>

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

<br>

<div align="center">

## ◆ 🧬 Sobrecarga de Funções (Overloading) ◆

</div>

Permite definir **múltiplas funções com o mesmo nome**, desde que tenham assinaturas diferentes (número, ordem e tipo de parâmetros).

> ⚠️ O **tipo de retorno não faz parte** da assinatura para fins de sobrecarga.

```csharp
public class Calculadora
{
    public static int Somar(int num1, int num2) => num1 + num2;
    public static int Somar(int num1, int num2, int num3) => num1 + num2 + num3;
    public static double Somar(double num1, double num2) => num1 + num2;
    public static string Somar(string s1, string s2) => s1 + s2;
}
```

```csharp
Calculadora.Somar(5, 3);              // → Somar(int, int)
Calculadora.Somar(10, 20, 30);        // → Somar(int, int, int)
Calculadora.Somar(2.5, 3.5);          // → Somar(double, double)
Calculadora.Somar("Olá, ", "Mundo!"); // → Somar(string, string)
```

<div align="center">

<kbd>✅ Flexibilidade</kbd> &nbsp; <kbd>✅ Código mais limpo</kbd> &nbsp; <kbd>✅ Legibilidade aprimorada</kbd>

</div>

<br>

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

<br>

<div align="center">

## ◆ 📝 Resumo ◆

<table>
<tr>
<td width="33%" align="center">
🔧<br><b>Funções vs. Procedimentos</b><br><sub>Funções retornam valor; procedimentos (<code>void</code>) executam ações sem retorno</sub>
</td>
<td width="33%" align="center">
🔄<br><b>Valor vs. Referência</b><br><sub>Por valor usa cópia; por referência (<code>ref</code>/<code>out</code>) altera o original</sub>
</td>
<td width="33%" align="center">
🧬<br><b>Sobrecarga</b><br><sub>Mesmo nome, assinaturas diferentes, mais flexibilidade</sub>
</td>
</tr>
</table>

</div>

<br>

<div align="center">

## ◆ 🛠️ Tecnologias ◆

<br>

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" width="50" height="50" alt="C#"/>
&nbsp;&nbsp;&nbsp;
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dotnetcore/dotnetcore-original.svg" width="50" height="50" alt=".NET"/>
&nbsp;&nbsp;&nbsp;
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/visualstudio/visualstudio-plain.svg" width="50" height="50" alt="Visual Studio"/>
&nbsp;&nbsp;&nbsp;
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/git/git-original.svg" width="50" height="50" alt="Git"/>
&nbsp;&nbsp;&nbsp;
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/github/github-original.svg" width="50" height="50" alt="GitHub"/>

<br><br>

| Linguagem | Plataforma | IDE | Versionamento |
|:-:|:-:|:-:|:-:|
| C# | .NET Framework | Visual Studio | Git & GitHub |

</div>

<br>

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

<br>

<div align="center">

## 👤 Autor

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/github/github-original.svg" width="20"/> **Arthur Ricardo**

<br>

[![GitHub](https://img.shields.io/badge/GitHub-Tp1Arthur-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Tp1Arthur)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-arthur--ricardo--silva-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://linkedin.com/in/arthur-ricardo-silva)
[![Gmail](https://img.shields.io/badge/Email-arthur.r.silva-EA4335?style=for-the-badge&logo=gmail&logoColor=white)](mailto:arthur.r.silva@gmail.com)

<br>

<sub>✨ Feito com 💻 e ☕ durante os estudos de ADS (IFRO) ✨</sub>

</div>
