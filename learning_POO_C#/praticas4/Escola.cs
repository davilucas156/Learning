using System;

public class Aluno
{
    public string nome;
    public static int totalAlunos = 0;

    public Aluno(string nome)
    {
        this.nome = nome;
        totalAlunos++;
    }

    public static void ExibirTotalAlunos()
    {
        Console.WriteLine("Total de alunos cadastrados: " + totalAlunos);
    }
}

class Program
{
    static void Main()
    {
        Aluno a1 = new Aluno("Ana");
        Aluno a2 = new Aluno("Bruno");
        Aluno a3 = new Aluno("Carlos");

        Console.WriteLine("Aluno: " + a1.nome);
        Console.WriteLine("Aluno: " + a2.nome);
        Console.WriteLine("Aluno: " + a3.nome);

        Aluno.ExibirTotalAlunos();
    }
}