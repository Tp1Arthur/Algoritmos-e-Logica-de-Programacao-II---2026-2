using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Saúde_e_Finanças
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }


        public static void MostrarMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("==== MENU PRINCIPAL ====");
                Console.WriteLine("1 - Calcular IMC (Índice de Massa Corporal)");
                Console.WriteLine("2 - Converter temperatura (Celsius ↔ Fahrenheit)");
                Console.WriteLine("3 - Calcular Juros Simples");
                Console.WriteLine("4 - Calcular Juros Compostos");
                Console.WriteLine("5 - Comparar Juros Simples e Compostos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        CalcularIMC(0, 0);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 0:

                        break;
                    default:

                        break;
                }


                Console.ReadKey();
            } while (opcao != 0);

        }

        public static double CalcularIMC(double peso, double altura)
        {
            Console.Write("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            
            Console.WriteLine("Valor do IMC: " + imc);
            return imc;
        }

    }
}
