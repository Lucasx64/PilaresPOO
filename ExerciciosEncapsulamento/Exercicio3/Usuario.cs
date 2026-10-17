using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosEncapsulamento.Exercicio3
{
    public class Usuario
    {
        public string Login { get; set; }

        private string Senha;

        public Usuario(string login, string senha) // Construtor
        {
            Login = login;
            this.Senha = senha;
        }

        public bool ConferirSenha(string tentativa)
        {
            return this.Senha == tentativa;   // Retorna true se a tentativa for igual a senha.
        }

        public void TrocarSenha(string senhaAtual, string novaSenha)
        {
            if (ConferirSenha(senhaAtual)) // Só troca a senha se a senha atual estiver correta.
            {
                this.Senha = novaSenha;
                Console.WriteLine("Senha alterada!");
            }
            else
            {
                Console.WriteLine("Senha atual incorreta.");
            }
        }
    }
}
