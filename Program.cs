using PilaresPOO;

Carro carro1 = new Carro("Hyundai", "HB20");

Console.WriteLine($"Marca: {carro1.Marca}");
Console.WriteLine($"Modelo: {carro1.Modelo}");



// Método Construtor -> obriga o objeto a ser criado de uma forma
// Pilares da Programação Orientada a Objetos
// Objetivo dos pilares: evitar estados inválidos.

// Encapsulamento:
// public -> acessado de qualquer lugar
// private -> acessar de dentro da classe
// internal -> acessado no mesmo projeto

// Encapsulamento:
// 1. Ler o dado (get)
// 2. Alterar o dado (set)

// Atributo -> public double Saldo() 

// Propriedade -> public double Saldo { get; set;  } (é um atributo com os métodos get e set)

// Exemplo:
internal class Conta
{
    public string Nome { get; set; }
    public void setNome(string nome)
    {
        Nome = nome;
    }
 

 public double Saldo
    {
        get;
        set

        {
            if (value > o)
                Saldo = value;
        }
    }
}

// Exemplo:
ContaBancaria conta1 = new ContaBancaria();

conta1.Saldo = -500;



// Exercícios

// Lista: Método Construtor


// 1.

Livro livro1 = new Livro("A Paixão Segundo GH", "Clarice Lispector", 400);

livro1.Exibir();



// 2.

Viagem viagem1 = new Viagem("Espanha", 10, 40.00);
Viagem viagem2 = new Viagem("Dinamarca", 5, 50.00);

viagem1.Exibir();
viagem2.Exibir();


// 3.

Contato c1 = new Contato("Ana", "(11) 99999-0000", "ana@email.com");
Contato c2 = new Contato("Bruno", "(21) 98888-1111");

c1.Exibir();
c2.Exibir();



// Lista Encapsulamento

// 1.

ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisita();
contador.RegistrarVisita();
contador.RegistrarVisita();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");


// 2.

Boletim boletim = new Boletim();
boletim.Aluno = "Ana";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: Nota {boletim.ObterNota()}");


// 3.

Usuario usuario = new Usuario("ana123", "segredo");

Console.WriteLine(usuario.ConferirSenha("1234"));
Console.WriteLine(usuario.ConferirSenha("segredo"));

usuario.TrocarSenha("errada", "novaSenha");
usuario.TrocarSenha("segredo", "novaSenha");

Console.WriteLine(usuario.ConferirSenha("novaSenha"));