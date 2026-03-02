// using System;

// class Program
// {
//     static int SomaVetorRecursivo(int[] vetor, int i)
//     {

//         if (i == vetor.Length)
//             return 0;

// else
//         return vetor[i] + SomaVetorRecursivo(vetor, i + 1);
//     }
//     static void Main(string[] args)
//     {
//         int n = 0;
//         int i = 0;

//         Console.WriteLine("escreva o valor para : n");
//         n = int.Parse(Console.ReadLine());

//         int[] vetor = new int [n];

//         for ( i = 0 ; i < vetor.Length;i++)
//         {
//             Console.WriteLine($"escreva o valor para {i+1}°");
//             vetor[i] = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine($"o resultado é " + SomaVetorRecursivo(vetor, 0));

//     }

// }