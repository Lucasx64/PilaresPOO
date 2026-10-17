using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosPolimorfismo.Exercicio3
{
    public class Instrumento
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Tocando um instrumento...");
        }
    }
}
