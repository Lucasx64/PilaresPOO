using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosEncapsulamento.Exercicio2
{
    internal class Boletim
    {
        public string Aluno { get; set; }

        private double Nota;


        public void DefinirNota(double valor)
        {
            if (valor >= 0 && valor <= 10) // Só aceita notas de 0 a 10.
            {
                Nota = valor; // Cumprindo a condição, altera a nota.
            }
            else
            {
                Console.WriteLine($"Nota inválida: {valor}"); // Se for uma nota diferente de 0 a 10, não altera a nota e mostra a mensagem.
            }
        }

        public double ObterNota()
        {
            return Nota;
        }
    }
}
