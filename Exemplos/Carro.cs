using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Exemplos
{
    internal class Carro
    {
        public string Marca;

        public string Modelo;

        // Método Construtor -> obriga o objeto a ser criado de uma forma
        // Não tem tipo de retorno
        // Tem o mesmo nome da classe
        // Função especial (não é int, não é double, não é void, não é string...)
        

        public Carro(string marca, string modelo)
        {
            // Recebe uma marca e um modelo
            this.Marca = marca;
            this.Modelo = modelo;
        }
    }
}
