using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosPolimorfismo.Exercicio2
{
    internal class CalculadoraDeArea
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }

        public double CalcularArea(double largura, double altura)
        {
            return largura * altura;
        }
    }
}
