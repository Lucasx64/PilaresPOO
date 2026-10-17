using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosAbstracao.Exercicio2
{
    internal class Quadrado : IForma
    {
        public Quadrado(int lado)
        {
            Lado = lado;
        }

        public int Lado { get; set; }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
