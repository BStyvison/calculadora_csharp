﻿namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione uma opção:");

            short res = short.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
                Console.WriteLine();
            }



        }

        static void Soma() 
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 =double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Segundo valor: ");
            double v2 =double.Parse(Console.ReadLine()) ;

            Console.WriteLine();

            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 / v2;
            Console.WriteLine($"O resultado da Divisão é {resultado}");

            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação é {resultado}");

            Console.ReadKey();
            Menu();

        }
    }
}