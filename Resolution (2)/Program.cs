using System;

namespace Resolution__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;

            do
            {
                Console.WriteLine("Insira seu nome de usuário: ");
                string nomeUsuario = Console.ReadLine();
                
                Console.WriteLine("Insira sua senha: ");
                string senha = Console.ReadLine();
                int tamanhoString = senha.Length;

                
                if(nomeUsuario == senha)
                {
                    do
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Seus dados são iguais. Digite uma senha deferente do seu nome de usuário! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    senha = Console.ReadLine();

                    } while (nomeUsuario == senha);
                    
                }
                if(tamanhoString >= 10)
                {

                    respostaCorreta = true;
                }

                else {
                    respostaCorreta = false;
                    
                    do
                    {
                        Console.WriteLine("Sua senha é menor que 10 caracteres, digite outra senha! ");
                        senha = Console.ReadLine();
                        tamanhoString = senha.Length;
                    }
                }
                
                }while( respostaCorreta == false);
                
    
        }
    }
}
