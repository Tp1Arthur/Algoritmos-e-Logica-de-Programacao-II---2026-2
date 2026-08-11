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
            int opcao = 0;

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

                switch (opcao)
                {
                    case 1:
                        CalcularIMC(0, 0);
                        break;

                    case 2:
                        Console.WriteLine("1. Celsius para Fahrenheit");
                        Console.WriteLine("2. Fahrenheit para Celsius");
                        Console.Write("Escolha a opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            CelsiusParaFahrenheit(0);
                        }
                        else if (opcao == 2)
                        {
                            FahrenheitParaCelsius(0);
                        }
                        else
                        {
                            Console.WriteLine("ERRO!!");
                        }

                        break;

                    case 3:
                        CalcularJurosSimples(0, 0, 0);
                        break;

                    case 4:
                        CalcularJurosCompostos(0, 0, 0);
                        break;

                    case 5:
                        CompararJuros(0, 0, 0);
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por usar!, até logo!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("ERRO!!!");
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

        public static double CelsiusParaFahrenheit(double c)
        {
            Console.Write("Digite a temperatura em celsius: ");
            c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 1.8) + 32;

            Console.WriteLine("Valor de Fahrenheit: " + f);
            return f;
        }

        public static double FahrenheitParaCelsius(double f)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            f = Convert.ToDouble(Console.ReadLine());

            double c = (f - 32) * 5 / 9;

            Console.WriteLine("Valor em Celsius: " + c);
            return c;
        }

        public static double CalcularJurosSimples(double capital, double taxa, int tempo)
        {
            Console.Write("Digite o capital: ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa: ");
            taxa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo: ");
            tempo = Convert.ToInt32(Console.ReadLine());

            double juros = capital * taxa * tempo;

            Console.WriteLine("Juros: " + juros);
            return juros;
        }

        public static double CalcularJurosCompostos(double capital, double taxa, int tempo)
        {
            Console.Write("Digite o capital: ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa: ");
            taxa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo: ");
            tempo = Convert.ToInt32(Console.ReadLine());

            double montante = capital * Math.Pow(1 + taxa, tempo);

            Console.WriteLine("Montante: " + montante);
            return montante;
        }

        public static void CompararJuros(double capital, double taxa, int tempo)
        {
            Console.Write("Digite o capital: ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa: ");
            taxa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo: ");
            tempo = Convert.ToInt32(Console.ReadLine());

            double juros = capital * taxa * tempo;
            double montante = capital * Math.Pow(1 + taxa, tempo);

            Console.WriteLine("Juros: " + juros);
            Console.WriteLine("Montante: " + montante);

            if (juros > montante)
            {
                Console.WriteLine("Juros simples resultam em maior montante");
            }
            else if (montante > juros)
            {
                Console.WriteLine("Juros compostos resultam em maior montante");
            }
            else
            {
                Console.WriteLine("Os dois resultam no mesmo montante.");
            }
        }
    }
}
