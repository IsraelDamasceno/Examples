using System;
using System.Collections.Generic;

namespace ListasExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> empregados = new List<Empregados>();
            Console.WriteLine("Quantos funcionarios deseja cadastrar");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("#Empregado número" + i + ":");
                Console.WriteLine("Digite o Id do Funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Digite o nome do funcionário");
                string nome = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite o salário do funcionário");
                double salario = double.Parse(Console.ReadLine());
                empregados.Add(new Empregados(id, nome, salario));
                Console.WriteLine("Funcionario Cadastrado com sucesso!");
                Console.WriteLine();
            }

            foreach (Empregados list in empregados)
            {
                Console.WriteLine(list);
            }
        }
    }
}
