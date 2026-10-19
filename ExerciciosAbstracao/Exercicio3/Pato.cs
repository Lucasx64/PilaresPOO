using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosAbstracao.Exercicio3
{
    internal class Pato : IVoador, INadador
    {
        public void Nadar()
        {
            Console.WriteLine("Pato nadando.");
        }

        public void Voar()
        {
            Console.WriteLine("Pato voando.");
        }
    }
}
