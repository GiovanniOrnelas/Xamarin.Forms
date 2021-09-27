using System;

namespace Relembrando
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0, salarioNovo = 0, ganho = 0;
            string nome = "";


            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            
            Console.WriteLine("Qual é a sua renda bruta?");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 2500)
            {
                ganho = salario * 0.12;
                salarioNovo = salario + ganho;

                Console.WriteLine( "\n" + nome + ", seu salário antigo é de: " + salario);
                Console.WriteLine(nome + ", seu salário novo é de: " + Math.Round(salarioNovo,2));
            }

            else
            {
                ganho = salario * 0.05;
                salarioNovo = salario + ganho;
                Console.WriteLine("\n" + nome + ", seu salário antigo é de: " + salario);
                Console.WriteLine(nome + ", seu salário novo é de: " + Math.Round(salarioNovo,2));
            }
            Console.ReadKey();
        }
    }
}
