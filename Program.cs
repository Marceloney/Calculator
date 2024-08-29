using System;
using System.Net.WebSockets;
using System.Threading.Channels;

namespace Calculator
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Multiplicacao();

        }
        static void Menu()
        {
            
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            //System.Console.WriteLine("O resultado da soma é: " + resultado); 
            Console.WriteLine($"O resultado da soma é: {resultado}");

        }

        static void Subtracao()
        {
            Console.Clear();

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {   
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();

        }

    }

}
