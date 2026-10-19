using PilaresPOO.ExerciciosAbstracao.Exercicio1;
using PilaresPOO.ExerciciosAbstracao.Exercicio2;
using PilaresPOO.ExerciciosAbstracao.Exercicio3;
using PilaresPOO.ExerciciosEncapsulamento.Exercicio1;
using PilaresPOO.ExerciciosEncapsulamento.Exercicio2;
using PilaresPOO.ExerciciosEncapsulamento.Exercicio3;
using PilaresPOO.ExerciciosHeranca.Exercicio1;
using PilaresPOO.ExerciciosHeranca.Exercicio2;
using PilaresPOO.ExerciciosHeranca.Exercicio3;
using PilaresPOO.ExerciciosMetodoConstrutor.Exercicio1;
using PilaresPOO.ExerciciosMetodoConstrutor.Exercicio2;
using PilaresPOO.ExerciciosMetodoConstrutor.Exercicio3;
using PilaresPOO.ExerciciosPolimorfismo.Exercicio1;
using PilaresPOO.ExerciciosPolimorfismo.Exercicio2;
using PilaresPOO.ExerciciosPolimorfismo.Exercicio3;

Exemplo:

Carro carro1 = new Carro("Hyundai", "HB20");

Console.WriteLine($"Marca: {carro1.Marca}");
Console.WriteLine($"Modelo: {carro1.Modelo}");


//_________________________________________________________________



// Método Construtor -> obriga o objeto a ser criado de uma forma
// Pilares da Programação Orientada a Objetos
// Objetivo dos pilares: evitar estados inválidos.


// Exemplo:
ContaBancaria conta1 = new ContaBancaria();

conta1.Saldo = -500;




//Exercícios - Método Construtor


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




// Encapsulamento:
// public -> acessado de qualquer lugar
// private -> acessar de dentro da classe
// internal -> acessado no mesmo projeto

// Encapsulamento:
// 1. Get -> Função de ler o dado
// 2. Set -> Função de alterar o dado

// Atributo -> public double Saldo() 

// Propriedade -> public double Saldo { get; set;  } (é um atributo com os métodos get e set)

//Exemplo:
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


// Exercícios - Encapsulamento

// 1.

ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisita();
contador.RegistrarVisita();
contador.RegistrarVisita();

contador.Visitas = 100;

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




// Herança:
// Ela exista para reaproveitar os códigos. Permite que consigamos pegar o que tem em comum entre as classes (campos/métodos/classes)
// public class Aluno : Pessoa   // ":" = "herda de" -> A classe Aluno herda atributos, métodos e propriedades da classe Pessoa. 


// Exemplo:

internal class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }


    public void Apresentar()
    {
        Console.WriteLine("Oi! Eu sou" + Nome);
    }


}

internal class Aluno : Pessoa
{
    // Nome, Idade, Matrícula
    public string Matricula { get; set; }
}

internal class Professor : Pessoa
{

}


// Exercícios - Herança

// 1.

Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";

cachorro.Comer();
cachorro.Latir();



// 2.

Funcionario ana = new Funcionario("Ana", 3000);
Gerente carlos = new Gerente("Carlos", 5000, 1500);

Console.WriteLine($"{ana.Nome}: R$ {ana.Salario:F2}");
Console.WriteLine($"{carlos.Nome}: R$ {carlos.Salario:F2} + bônus = R$ {carlos.SalarioComBonus():F2}");


// 3.

Carro carro = new Carro("Fiat", "Uno", 4);
Moto moto = new Moto("Honda", "CG 160", 160);

carro.Exibir();
carro.ExibirPortas();

moto.Exibir();
moto.ExibirCilindradas();



// Polimorfismo (Muitas formas)
// Uma mesma função pode ter muitas formas.
//
// Sobrecarga: Mesmo nome, parâmetros diferentes (um recebe 2 números, outro 3 números, outro 2 números decimais (double))
// Sobrescrita: Existe por causa da herança (virtual e override)
// override -> sobreescrever
// virtual -> esse método PODE SER sobreescrito

Exemplo de sobrecarga:

 Criando a classe Calculadora:
 
 public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }
}


No Program.cs:
Calculadora calc = new Calculadora();

Console.WriteLine(calc.Somar(2, 3));       // 5   -> 2 inteiros
Console.WriteLine(calc.Somar(2, 3, 4));    // 9   -> 3 inteiros
Console.WriteLine(calc.Somar(2.5, 1.5));   // 4   -> 2 decimais


// Exemplo de sobrescrita:
//
// Criando a classe Animal:
//
internal class Animal
{
    public virtual void FazerSom() // virtual -> informa que esse método PODE SER sobreescrito pelas classes filhas
    {
        Console.WriteLine("O animal faz um som");
    }
}
//
//
// Criando a classe Cachorro que herda atributos da classe Animal:
internal class Cachorro : Animal
{
    public override void FazerSom()  //override -> sobreescreve o FazerSom() da classe Animal
    {
        Console.WriteLine("Au au!");
    }
}
//
// No Program.cs:
Animal animal = new Animal();
Cachorro cachorro = new Cachorro();

animal.FazerSom();     // O animal faz um som.
cachorro.FazerSom();   // Au au!  -> versão reescrita


// Exercicios - Polimorfismo:
//
// 1.

Saudacao s = new Saudacao();

s.Cumprimentar();
s.Cumprimentar("Ana");
s.Cumprimentar("Bruno", 25);


// 2.

CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine($"Quadrado: {calc.CalcularArea(4)}");
Console.WriteLine($"Retângulo: {calc.CalcularArea(3, 5)}");


// 3.

Instrumento instrumento = new Instrumento();
Violao violao = new Violao();

instrumento.Tocar();
violao.Tocar();



// Abstração: mostrar o que faz e esconde como faz, criando "fachadas".
// Interface (Contrato) -> a tal "fachada"; um contrato de métodos sem corpo; nome começa com "I" (i maiúsculo).
// A interface leva apenas métodos.
// A classe é implementada pela interface com ":".
//
//
// 
// Exercícios - Abstração
//
// 1.

Pix pix = new Pix();
Cartao cartao = new Cartao();

pix.Pagar(50);
cartao.Pagar(120);


// 2.

Quadrado quadrado = new Quadrado(4);
Retangulo retangulo = new Retangulo(3, 5);

Console.WriteLine($"Quadrado: {quadrado.CalcularArea()}");
Console.WriteLine($"Retângulo: {retangulo.CalcularArea()}");


// 3.

Pato pato = new Pato();
Peixe peixe = new Peixe();

pato.Voar();
pato.Nadar();
peixe.Nadar();
