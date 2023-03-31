using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEscolha o operador (digite o número designado)");
            Console.WriteLine("0 - soma");
            Console.WriteLine("1 - subtração");
            Console.WriteLine("2 - multiplicação");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - resto(em breve)");
            Console.WriteLine("5 - exponenciação(em breve)");
            Console.WriteLine("6 - radiciação(em breve)");
            Console.WriteLine("7 - mais opções(inativo)");

            int operador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o primeiro número");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nResultado");
            int resultado = 0;

            if (operador == 0) {resultado = a + b;}
            else if (operador == 1) {resultado = a - b;}
            else if (operador == 2) {resultado = a * b;}
            else if (operador == 3) {resultado = a / b;}
            else {Console.WriteLine("Operador inválido");}
            Console.WriteLine(resultado);
            Console.WriteLine("");
        }
    }
}
