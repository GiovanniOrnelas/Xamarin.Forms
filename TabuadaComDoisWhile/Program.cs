using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaComDoisWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int contadorDoPrimeiroWhile = 1, contadorDoSegundoWhile = 1, resultado =0;

            while (contadorDoPrimeiroWhile <= 10)
            {
               
                while (contadorDoSegundoWhile <= 10)
                {
                    resultado = contadorDoPrimeiroWhile * contadorDoSegundoWhile;
                    Console.WriteLine(contadorDoPrimeiroWhile + " X " + contadorDoSegundoWhile + " = " + resultado);
                    contadorDoSegundoWhile++;
                }
               
                contadorDoPrimeiroWhile++;
                contadorDoSegundoWhile = 0;
                Console.WriteLine("\n");
            }
            
            Console.ReadKey();
        }
    }
}
