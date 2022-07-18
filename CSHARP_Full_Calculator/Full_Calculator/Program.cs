using System;

namespace Full_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desligar = "0";

            Console.WriteLine("Isto é uma Calculadora.");
            Console.WriteLine("Digite '1' para continuar ou '0' para finalizar o programa");
            string ligar = Console.ReadLine();
            Console.WriteLine("Digite o primeiro número: ");
            if (ligar == "1")
            {
                while (desligar != "0")

                    Console.WriteLine("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o operador (+) para Adição, (-) Subtração, (*) Multiplicação ou (/) Divisão: ");
                    string operador = Console.ReadLine();

                    Console.WriteLine("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                

                switch (operador)
                {
                    case "+":
                        Console.WriteLine("Resultado da soma: " + somar(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultado da subtração: " + subtrair(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultado da multiplicação: " + multiplicar(num1, num2));
                        break;
                    case "/":
                        Console.WriteLine("Resultado da divisão: " + dividir(num1, num2));
                        break;
                }
            
            }
        }

        public static string somar(double num1, double num2)
        {
            return (num1 + num2).ToString();
        }
        public static string subtrair(double num1, double num2)
        {
            return (num1 - num2).ToString();
        }
        public static string multiplicar(double num1, double num2)
        {
            return (num1 * num2).ToString();
        }
        public static string dividir(double num1, double num2)
        {
            if (valorDividendoMenorOuIgualAZero(num2))
            {
                return "É impossível dividir um valor por zero ou menor que zero";
            }
            return (num1 / num2).ToString();

            bool valorDividendoMenorOuIgualAZero(double num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
