using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosHeranca.Exercicio1
{
    internal class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome}: Au au!");
        }
    }
}
