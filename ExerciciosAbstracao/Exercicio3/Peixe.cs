using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosAbstracao.Exercicio3
{
    internal class Peixe : INadador
    {
      public void Nadar()
        {
            Console.WriteLine("Peixe nadando.");
        }
    }
}
