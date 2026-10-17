using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosHeranca.Exercicio1
{
    internal class Animal
    {
        public string Nome;
        
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
}
