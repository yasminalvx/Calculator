using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short option = Menu();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Soma(v1, v2); break;
                case 2: Subtracao(v1, v2); break;
                case 3: Multiplicacao(v1, v2); break;
                case 4: Divisao(v1, v2); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }

        static short Menu () {
            Console.Clear(); //limpar tela

            Console.WriteLine("Qual operação realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("Selecione a opção: ");
            short option = short.Parse(Console.ReadLine());

            Console.Clear(); //limpar tela

            return option;
        }

        static void Soma (float v1, float v2) {
            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
        static void Subtracao (float v1, float v2) {
            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
        }
        static void Divisao (float v1, float v2) {
            float resultado = v1 / v2;
            Console.WriteLine("O resultado da divisão é: " + resultado);
        }
        static void Multiplicacao (float v1, float v2) {
            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }

    }
}
