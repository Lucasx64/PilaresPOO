using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosHeranca.Exercicio3
{
    internal class Moto : Veiculo
    {
        public Moto(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }

        public int Cilindradas { get; set; }

        public void ExibirCilindradas()
        {
            Console.WriteLine($"Cilindradas: {Cilindradas}cc");
        }
    }
}
