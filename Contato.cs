using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Contato
    {
        public string Nome;
        public string Telefone;
        public string Email;

        
        public Contato (string nome, string telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        public Contato (string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            // this.Email = "Não informado" (Outra forma do código, sem utilizar if e else)
        }
        
        public void Exibir()
        {
            if (Email == null)
            {
                Console.WriteLine($"{Nome} | {Telefone} | Não informado");
            }
            else
            {
                Console.WriteLine($"{Nome} | {Telefone} | {Email}");
            }
            
        }
    }
}
