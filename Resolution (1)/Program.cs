using System;

namespace New_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
           bool resposta= false;
           
            do
            {
            
            Console.WriteLine("Apresente um número de 1 a 10: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número inválido! ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Número válido! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Fim do programa");
                resposta = true;
            }

            } while (resposta == false);
        
        }
    }
}
