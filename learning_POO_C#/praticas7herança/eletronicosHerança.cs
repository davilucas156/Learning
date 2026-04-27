using System;

public class Dispositivo
{
    protected string marca;
    protected string modelo;

    public Dispositivo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
    }
}

public class Celular : Dispositivo
{
    protected int armazenamento; 

    public Celular(string marca, string modelo, int armazenamento)
        : base(marca, modelo)
    {
        this.armazenamento = armazenamento;
    }

    public void ExibirDadosCelular()
    {
        base.ExibirDados();
        Console.WriteLine($"Armazenamento: {armazenamento} GB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Celular celular = new Celular("Samsung", "Galaxy S23", 256);
        celular.ExibirDadosCelular();
    }
}
