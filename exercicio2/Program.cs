using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, qntde_filhos = 0, totalFilhos = 0;

            double salario = 0, salarioTotal = 0, mediaSalario = 0, mediaFilhos = 0, percentualDePessoasComSalario1000OuMais = 0, qntdePessoasCom1000OuMais = 0, qntde_pessoas = 0;


            string resposta = "";
            
            Console.WriteLine("Você deseja realizar a pesquisa da prefeitura?");
            resposta = Console.ReadLine();


                Console.WriteLine("\nVocê deseja cadastrar quantas pessoas?");
                qntde_pessoas = Convert.ToDouble(Console.ReadLine());

                while (contador <= qntde_pessoas)
                {
                    Console.WriteLine("\nQual o salário da " + contador + "º pessoa");
                    salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nQuantos filhos essa " + contador + "º pessoa tem?");
                    qntde_filhos = Convert.ToInt32(Console.ReadLine());

                    salarioTotal += salario;
                    totalFilhos += qntde_filhos;

                    if (salario >= 1000)
                    {
                        qntdePessoasCom1000OuMais++;
                    }

                    contador++;
                }
               
                mediaSalario = salarioTotal / 5;

                Console.WriteLine("\nA média do salário das " + qntde_pessoas + " pessoas é de: R$" + Math.Round(mediaSalario,2));
                Console.WriteLine("A quantidade total de filhos das " + qntde_pessoas + " pessoas é de: " + totalFilhos);
                Console.WriteLine("Das " + qntde_pessoas + " pessoas, apenas " + qntdePessoasCom1000OuMais + " pessoas tem um salário igual ou maior que R$1000");

                Console.ReadKey();
        }
    }
}
