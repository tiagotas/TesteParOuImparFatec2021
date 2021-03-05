using System;

namespace TesteParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_qualquer;

            Console.WriteLine("Digite um número inteiro qualquer: ");
            numero_qualquer = Convert.ToInt32(Console.ReadLine());

            double resto = numero_qualquer % 2;

            //Console.WriteLine("O resto é {0} ", resto);

            if(resto == 0)
            {
                Console.WriteLine("O número digitado é PAR");

            } else
            {
                Console.WriteLine("O número digitado é ÍMPAR");
            }


            /**
             * Segunda Maneira.
             */


            Console.WriteLine("Digite um número inteiro qualquer: ");
            numero_qualquer = Convert.ToInt32(Console.ReadLine());


            if ( (numero_qualquer % 2) == 0 )
            {
                Console.WriteLine("O número digitado é PAR");
            }
            else
            {
                Console.WriteLine("O número digitado é ÍMPAR");
            }





            Console.ReadKey();

        }
    }
}
