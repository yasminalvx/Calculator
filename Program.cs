//Program.cs
//Calculadora com as quatro operações básicas e com cálculo de porcentagem
//Possui menu interativo
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu () {
            Console.Clear(); //limpar tela

            Console.WriteLine("Qual operação realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("Selecione a opção: ");
            short option = short.Parse(Console.ReadLine());

            Console.Clear(); //limpar tela

            switch (option)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Porcentagem(); break;
                case 6: System.Environment.Exit(0); break; //Processo finalizado, retorna um código de êxito para o sistema
                default: Menu(); break;
            }

        }
        //operação soma
        static void Soma () { 
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey(); //Para o sistema mostrar o resultado antes de abrir o menu novamente
            Menu();
        }
        //operação subtração
        static void Subtracao () { 
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        //operação divisão
        static void Divisao () { 
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        //operação multiplicação
        static void Multiplicacao () { 
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        //cálculo de porcentagem
        static void Porcentagem () { 
            Console.WriteLine("Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Percentual(%): ");
            float p = float.Parse(Console.ReadLine());

            float resultado = v1 * p / 100;
            Console.WriteLine($"{p}% de {v1} é igual a " + resultado);
            Console.ReadKey();
            Menu();
        }

    }
}
