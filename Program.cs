using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEscolha o operador (digite o número do operador escolhido)");
            Console.WriteLine("0 - soma");
            Console.WriteLine("1 - subtração");
            Console.WriteLine("2 - multiplicação");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - resto(em breve)");
            Console.WriteLine("5 - exponenciação(em breve)");
            Console.WriteLine("6 - radiciação(em breve)");
            Console.WriteLine("7 - mais opções(inativo)");

            int operador = Convert.ToInt32(Console.ReadLine());

            while (operador < 0 || operador > 3)
            {
                Console.WriteLine("\nOperador inválido, digite outro\n");
                operador = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nDigite o primeiro número");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nResultado");
            
            //

            float resultado = operador == 0 ? a + b :
                            operador == 1 ? a - b :
                            operador == 2 ? a * b :
                            operador == 3 ? a / b :
                            0;
            
            Console.WriteLine(resultado);

        }
    }
}
