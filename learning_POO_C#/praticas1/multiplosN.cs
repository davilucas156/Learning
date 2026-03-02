using System;


class Program2
{
    static void MultiplosDeN(int n, int q)
    {

        if (q == 0)
            return;

        MultiplosDeN(n, q - 1);
        Console.WriteLine($"{n} x {q} = {n*q} ");
      

    }
    static void Main(string[] args)
    {
        int n = 0;
        int q = 0;

        Console.WriteLine("escreva o valor para : n");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("escreva o valor para : q");
        q = int.Parse(Console.ReadLine());

        Console.WriteLine($"os numeros multiplos de {n}");
        MultiplosDeN(n, q);

    }

}