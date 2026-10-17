using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.ExerciciosMetodoConstrutor.Exercicio1
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;

        public Livro (string titulo, string autor, int paginas)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Paginas = paginas;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Titulo} de {Autor} ({Paginas} páginas)");
        }
    }
}
