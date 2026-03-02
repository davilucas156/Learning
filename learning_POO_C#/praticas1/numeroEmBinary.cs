using System;

class Binary
{
    static void ImprimirBinario(int n)
    {
        if (n > 0)
        {
            ImprimirBinario(n / 2);
            
            
            Console.Write(n % 2);
        }
    }

    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Resultado em binário: ");
        
        if (numero == 0)
        {
            Console.Write("0");
        }
        else
        {
            ImprimirBinario(numero);
        }

        Console.WriteLine(); 
    }
}