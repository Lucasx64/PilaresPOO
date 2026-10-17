using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PilaresPOO.ExerciciosPolimorfismo.Exercicio3
{
    internal class Violao : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Violão: plim plim.");
        }
    }
}
