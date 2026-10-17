using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosAbstracao.Exercicio1
{
    internal class Cartao : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento de R$ {valor:F2} no cartão.");
        }
    }
}
