using System;

class Funcionario
{
    private string nome;
    private double salario;

    public string getNome() { return nome; }
    public double getSalario() { return salario; }

    public void setNome(string n) { nome = n; }
    public void setSalario(double s) { salario = s; }

    public void AumentarSalario(double percentual)
    {
        salario = salario + (salario * percentual / 100);
    }
}

class Program
{
    static void Main()
    {
        Funcionario func = new Funcionario();
        func.setNome("Carlos");
        double salarioInicial = 2000;
        func.setSalario(salarioInicial);
        double percentual = 10;
        func.AumentarSalario(percentual);
        Console.WriteLine("Funcionário: " + func.getNome());
        Console.WriteLine("Salário inicial: " + salarioInicial);
        Console.WriteLine("Percentual de aumento: " + percentual + "%");
        Console.WriteLine("Novo salário: " + func.getSalario());
    }
}