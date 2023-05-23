using System;

namespace ConsoleApplication1
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            var num1 = Console.Read();
            var num2 = Console.Read();

            var pares = 0;
            var impares = 0;
            var primos = 0;
            
            for (var i = num1; i < num2; i++)
            {
                pares += i % 2 == 0 ? 1 : 0;
                impares += i % 2 != 0 ? 1 : 0;
                primos += i % 2 != 0 && i % 3 != 0 ? 1 : 0;
            }
            
            Console.WriteLine("Existem " + (num1 - num2) + " entre eles.");
        }
    }
}