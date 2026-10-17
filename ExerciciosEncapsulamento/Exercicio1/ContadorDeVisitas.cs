using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosEncapsulamento.Exercicio1
{
    internal class ContadorDeVisitas
    {
        public int Visitas { get; set; }

        public void RegistrarVisita()   // Sempre que falar crie um método, esse é o modelo padrão: 
        {
            Visitas++; // Soma 1 às visitas // Pode utilizar também Visita = Visita + 1;
        }

        public int ObterTotal()
        {
            return Visitas;
        }
        
    }
}
