using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosAbstracao.Exercicio1
{
    public class Pix : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento de R$ {valor:F2} no cartão.");
        }
    }
}
