using System;

public class Curso
{
    public string nome;
    public int cargaHoraria;

    public Curso(string nome)
    {
        this.nome = nome;
        this.cargaHoraria = 40;
    }

    public Curso(string nome, int cargaHoraria)
    {
        this.nome = nome;
        this.cargaHoraria = cargaHoraria;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Curso: " + nome + " | Carga Horária: " + cargaHoraria + "h");
    }

    ~Curso()
    {
        Console.WriteLine("Curso " + nome + " removido da memória.");
    }
}

class Program
{
    static void Main()
    {
        Curso c1 = new Curso("Análise de Sistemas");
        Curso c2 = new Curso("Programação C#", 80);

        c1.ExibirDados();
        c2.ExibirDados();

        Console.WriteLine("Os cursos foram criados com sucesso.");
    }
}