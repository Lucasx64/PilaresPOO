using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class ContadorDeVisitas
    {
        private int visitas = 0;

        public void RegistrarVisita()
        {
            visitas++; // Soma 1 às visitas
        }

        public int ObterTotal()
        {
            return visitas;
        }
        
    }
}
