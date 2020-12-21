using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisioList
{
    class Funcionario
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }



        public void  AdicionarSalario(double porcentagem)
        {
            double percentual = porcentagem / 100.0; // Calcula a porcentagem para ser adicionada.
            Salary =+ (percentual * Salary) + Salary; // Calcula quanto adicionar no salario.
           

        }




    }
}
