```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>(); // Cria uma nova Lista
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("********** MENU **********");
                Console.WriteLine("1 - Adicionar nome na lista");
                Console.WriteLine("2 - Imprimir Lista");
                Console.WriteLine("3 - Remover item da lista");
                Console.WriteLine("4 - Ordenar a Lista");
                Console.WriteLine("5 - SAIR");
                Console.WriteLine(" ");
                Console.Write("informe sua Opção");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarNomes(nomes);
                        break;
                    case 2: ImprimirLista(nomes);
                        break;
                    case 3: RemoverItem(nomes);
                        break;
                    case 4: ImprimirLista(nomes);
                        break;
                    default: Console.WriteLine("Opção Invalida! Tente Novamente!");
                        break;
                }
            } while (opcao != 5);
            
            
            
            

        }

        // Função para ordenar a Lista

        public static void OrdenarLista(List<string> lista)
        {
            if (lista.Count == 0)
                Console.WriteLine("Lista Vazia!!!");
            else
            {
                Console.WriteLine("Deseja Ordenar a lista em: ");
                Console.WriteLine("1 - Ordem Crescente");
                Console.WriteLine("2 - Ordem Decrescente");
                Console.Write("Digite sua Opção: ");
                int opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                    lista.Sort();
                else
                    if (opc == 2)
                    {
                        lista.Sort();
                        lista.Reverse();

                    }
                else
                    {
                        Console.WriteLine("ERRO!!!");
                    }
            }
            Console.WriteLine("Imprimindo Lista Ordenada");
            ImprimirLista(lista);
        }



        //Função para Remover Item da Lista
        public static void RemoverItem (List <string> lista)
        {
            if (lista.Count == 0)
                Console.WriteLine("LISTA VAZIA");

            else
            {
                ImprimirLista(lista);
                Console.Write("Qual item deseja remover: ");
                int indice = Convert.ToInt32(Console.ReadLine());

                if (indice < 1 || indice > lista.Count)
                {
                    Console.WriteLine("Opção Invalida!");
                }

                else
                {
                    lista.RemoveAt(indice - 1 );
                    Console.WriteLine("Item Removido com Sucesso!");
                }


            }



        }


        // função para Mostrar a Lista
        public static void ImprimirLista(List<string> lista)
        {
            Console.WriteLine("Listagem: ");
            int posicao = 1;
            foreach (string nome in lista)
            {
                Console.WriteLine($"{posicao} - {nome}");
                posicao++;
                Console.WriteLine(" ");
            }
        }


        // função para adicionar um elemento na Lista

        public static void AdicionarNomes(List<string> lista)
        {
            string nome;
            char opc = 'n';

            do
            {
                Console.Write("Informe o nome a ser Adicionado na lista: ");
                nome = Console.ReadLine();
                lista.Add(nome);
                Console.WriteLine(nome + " inserido na lista com sucesso!");
                Console.Write("Digite S para adicionar um nome: ");
                opc = Convert.ToChar(Console.ReadLine());

            } while (opc == 's' || opc == 'S');
        }
    }
}


```
