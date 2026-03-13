using System;

class Program{
class Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public int anoFabricacao;
}

    static void exibirInformacoes(Carro carro)
    {

        Console.WriteLine();
        Console.Write(carro.marca + "  - ");
        Console.WriteLine(carro.modelo);
        Console.WriteLine(carro.cor);
    }

    static void buzinar()
    {
        Console.WriteLine("biiiiiibiiiiii vrumvrum");
    }

    static void Main(string[] args)
    {
        Carro carro = new Carro();

        carro.marca = "Mustang";
        carro.modelo = "super Snake";
        carro.cor = "vermelho";
        carro.anoFabricacao = 2022;

        exibirInformacoes(carro);
        buzinar();

    }
}