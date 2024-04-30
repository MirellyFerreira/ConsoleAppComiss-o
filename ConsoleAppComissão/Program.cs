using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppComissão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new String[5];
            double[] peso = new double[5];
            double[] altura = new double[5];

            for (int i = 0; i <= 5; i++) 
            {
                Console.WriteLine("Informe o nome da pessoa: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("informe o peso da pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("informe a altura da pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());

                
                {
                    for (int j = 0; j <= 4 j++)
                    
                {
                        Console.WriteLine("Vendedor: " + vendedor[j] + "valor da venda: " + venda[j].ToString("C") + "valor da comissão: " + comissao[j].ToString("C"));

                           
                    
                    }
                }
            }

        }
    }
}
