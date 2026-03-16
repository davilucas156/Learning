using System;

class ContaBancaria
{
    private string titular;
    private double saldo;

    public string getTitular() { return titular; }
    public double getSaldo() { return saldo; }

    public void setTitular(string nome) { titular = nome; }
    public void setSaldo(double valor) { saldo = valor; }

    public void Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine("Depósito realizado: " + valor);
    }

    public void Sacar(double valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado: " + valor);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.setTitular("Maria");
        conta.setSaldo(0);
        conta.Depositar(500);
        conta.Sacar(200);
        Console.WriteLine("Titular: " + conta.getTitular());
        Console.WriteLine("Saldo final: " + conta.getSaldo());
    }
}