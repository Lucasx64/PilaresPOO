using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosHeranca.Exercicio3
{
    internal class Veiculo
    {
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Marca} {Modelo}");
        }
    }
}
