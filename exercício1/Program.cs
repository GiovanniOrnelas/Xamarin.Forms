using System;

namespace exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 1, qntde_Negativo = 0,
                qntde_Neutro = 0, qntde_Positivo = 0; ;

            string numeroNegativo = "", numeroPositivo = ""; 

            while (contador <= 5)
            {
                Console.WriteLine("Digite um número");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    numeroNegativo += numero + ", ";
                    qntde_Negativo++;
                }

                else if (numero == 0)
                {
                    qntde_Neutro++;
                }

                else
                {
                    numeroPositivo += numero + ", ";
                    qntde_Positivo++;
                }

                contador++;
            }

            Console.WriteLine("A quantidade de números negativos são: " + qntde_Negativo + ", sendo eles: " + numeroNegativo);
            Console.WriteLine("A quantidade de números neutros são: " + qntde_Neutro);
            Console.WriteLine("A quantidade de números positivos são: " + qntde_Positivo + ", sendo eles: " + numeroPositivo);

            Console.ReadKey();
        }
    }
}
