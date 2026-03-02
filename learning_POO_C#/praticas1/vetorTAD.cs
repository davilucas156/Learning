using System;

class Vet
{
    private int[] elementos;

    public Vet(int tamanho)
    {
        elementos = new int[tamanho];
    }

    public void Inserir(int posicao, int valor)
    {
        if (posicao >= 0 && posicao < elementos.Length)
            elementos[posicao] = valor;
    }

    public int Recuperar(int posicao)
    {
        return elementos[posicao];
    }

    public bool Existe(int valor)
    {
        foreach (int x in elementos)
        {
            if (x == valor) return true;
        }
        return false;
    }

    public void SomarTudo()
    {
        int pares = 0, impares = 0;
        foreach (int x in elementos)
        {
            if (x % 2 == 0) pares += x;
            else impares += x;
        }
        Console.WriteLine("Soma Pares: " + pares);
        Console.WriteLine("Soma Ímpares: " + impares);
        Console.WriteLine("Soma Total: " + (pares + impares));
    }

    public void Listar()
    {
        foreach (int x in elementos) Console.Write(x + " ");
        Console.WriteLine();
    }
}

class Vetprincipal
{
    static void Main()
    {
        Console.Write("Tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        Vet meuVet = new Vet(n);

        meuVet.Inserir(0, 10);
        meuVet.Inserir(1, 5);
        meuVet.Listar();
        meuVet.SomarTudo();
    }
}