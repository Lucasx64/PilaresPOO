using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosHeranca.Exercicio2
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, double salario, double bonus) : base(nome, salario)
        {
            Bonus = bonus;
        }

        public double Bonus { get; set; }

        public double SalarioComBonus()
        {
            return Salario + Bonus;
        }
    }
}
