using System;

namespace Relembrando02
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 1, numero = 0, divisor = 1, qntdeDivisores = 0;

            while (contador <= 10)
            {
                Console.WriteLine("\nDigite o [" + contador + "] número");
                numero = Convert.ToDouble(Console.ReadLine());

                while (divisor <= numero)
                {
                    if (numero % divisor == 0)
                    {
                        qntdeDivisores++;
                    }
                    divisor++;
                }

                if (qntdeDivisores == 2)
                {
                    Console.WriteLine("\nO número " + numero + " é primo");
                }
                
                else
                {
                    Console.WriteLine("\nO número " + numero + " não é primo");
                }
                contador++;
                qntdeDivisores = 0;
                divisor = 0;
            }
            Console.ReadKey();
        }
    }
}
