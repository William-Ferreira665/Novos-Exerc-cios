using System;

namespace Challange_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeroAntecessor = 0;
            int numeroSucessor = 1;
            int fib;

            
            for (int i = 0; i <500;  i++ )
            {  
                if(i == 610)
                {
                    break;
                }

                fib = numeroAntecessor + numeroSucessor; 
                Console.WriteLine (fib);
                numeroAntecessor = numeroSucessor; 
                numeroSucessor = fib;
            }


        }
    }
}
