using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha o operador (digite o número designado)");
            Console.WriteLine("0 - soma");
            Console.WriteLine("1 - subtração");
            Console.WriteLine("2 - multiplicação");
            Console.WriteLine("3 - divisão");
            string stringOperador = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro número");
            string stringA = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Digite o segundo número");
            string stringB = Console.ReadLine();
            Console.WriteLine("");

            //Conversão das informações de texto em int

            int a = Convert.ToInt32(stringA);
            int b = Convert.ToInt32(stringB);
            int operador = Convert.ToInt32(stringOperador);

            //cálculo

            Console.WriteLine("Resultado");
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
