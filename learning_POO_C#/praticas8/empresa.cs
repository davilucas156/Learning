using System;

namespace Working;

public interface IBonus
{
    double CalcularBonus();
}

class Funcionario
{
    public string nome;
    public int idade;
    public double salario;

    public Funcionario(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
    }

    public virtual void exibirDados()
    {
        Console.WriteLine($"{nome}, {idade} anos, R${salario}");
    }
}


class Gerente : Funcionario, IBonus
{
    public string DEPARTAMENTO; 

    public Gerente(string nome, int idade, double salario, string departamento) 
        : base(nome, idade, salario)
    {
        this.DEPARTAMENTO = departamento;
    }

    public override void exibirDados()
    {
        base.exibirDados();
        Console.WriteLine($"Departamento: {DEPARTAMENTO}");
    }

    public double CalcularBonus()
    {
        return salario * 0.2;
    }
}


class Desenvolvedor : Funcionario, IBonus
{
    public string LINGUAGEM; 

    public Desenvolvedor(string nome, int idade, double salario, string linguagem) 
        : base(nome, idade, salario)
    {
        this.LINGUAGEM = linguagem;
    }

    public override void exibirDados()
    {
        base.exibirDados();
        Console.WriteLine($"Linguagem: {LINGUAGEM}");
    }

    public double CalcularBonus()
    {
        return salario * 0.1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerente manager = new Gerente("Gustavo", 21, 5000, "TI");
        Desenvolvedor dev1 = new Desenvolvedor("Davi", 23, 4000, "C#");

        Console.WriteLine(" Dados do Gerente ");
        manager.exibirDados();
        Console.WriteLine($"Bônus: R${manager.CalcularBonus()}");

        Console.WriteLine("\n Dados do Desenvolvedor ");
        dev1.exibirDados();
        Console.WriteLine($"Bônus: R${dev1.CalcularBonus()}");
    }
}
