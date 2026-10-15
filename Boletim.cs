using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Boletim
    {
        public string Aluno { get; set; }

        private double nota;


        public void DefinirNota(double valor)
        {
            if (valor >= 0 && valor <= 10)
            {
                nota = valor;
            }
            else
            {
                Console.WriteLine($"Nota inválida: {valor}");
            }
        }

        public double ObterNota()
        {
            return nota;
        }
    }
}
