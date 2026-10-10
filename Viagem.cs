using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Viagem
    {
        public string Destino;
        public int Dias;
        public double ValorDiaria;

        public Viagem (string destino, int dias, double valorDiaria)
        {
            this.Destino = destino;
            this.Dias = dias;
            this.ValorDiaria = valorDiaria;
        }

        public double CalcularTotal()
        {
            return Dias * ValorDiaria;
        }
        public void Exibir()
        {
            Console.WriteLine($"{Destino}: {Dias} dias x R$ {ValorDiaria} = R$ {CalcularTotal()}");
        }
    }
}
