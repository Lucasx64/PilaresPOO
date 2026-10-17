using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosHeranca.Exercicio3
{
    internal class Carro : Veiculo
    {
        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }

        public int Portas { get; set; }

        public void ExibirPortas()
        {
            Console.WriteLine($"Portas: {Portas}");
        }


    }
}
