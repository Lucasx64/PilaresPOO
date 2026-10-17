using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosAbstracao.Exercicio2
{
    internal class Retangulo : IForma
    {
        public Retangulo(int largura, int altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public int Largura { get; set; }

        public int Altura { get; set; }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}
