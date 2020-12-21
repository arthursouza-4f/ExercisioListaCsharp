using System;
using System.Collections.Generic;
namespace ExercisioList
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quantas pessoas vão ser registradas?");
            int registro = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();
            

            for (int i = 0; i < registro; i++)
            {
                var func = new Funcionario();
                               
                Console.WriteLine(" Funcionario " );
                Console.Write("ID: ");
                func.Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                func.Name = Console.ReadLine();
                Console.Write("Salario: ");
                func.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");
                funcionarios.Add(func);

            }

            Console.Write("Entre com id para adicionar ao salario: ");
            int idpor = int.Parse(Console.ReadLine());
            var salario = funcionarios.Find(x => x.Id == idpor);


            if (salario == null) 
            {
                Console.WriteLine("Esse id não existe.");
            }
            else
            {
                Console.WriteLine("Entre com a porcentagem para ser adicionado ao salario: ");
                double percentual = double.Parse(Console.ReadLine());
                salario.AdicionarSalario(percentual);
            }

            Console.WriteLine("Lista Atualizada");
            foreach (var f in funcionarios)
            {
                  Console.WriteLine(f.Id + "," + f.Name + ", " + f.Salary);
            }

        }
    }
}
