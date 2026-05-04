using System;


namespace Biblioteca;

class Itembiblioteca
{
    protected string Titulo;
    protected int AnoPublicacao;

    public Itembiblioteca(string titulo, int ano)
    {
        this.Titulo = titulo;
        this.AnoPublicacao = ano;
    }

    public virtual void ExibeInfo()
    {
        Console.WriteLine($"titulo: {Titulo} ano: {AnoPublicacao}");
    }
}

class Livro : Itembiblioteca, Iemprestimo
{
    string Autor;
    public Livro(string Titulo, int AnoPublicacao, string Autor) : base(Titulo, AnoPublicacao)
    {
        this.Autor = Autor;
    }

    public override void ExibeInfo()
    {
        base.ExibeInfo();
        Console.WriteLine($"autor : {Autor}");
    }
    public void Emprestar()
    {
        Console.WriteLine($"Livro {Titulo} emprestado!");
    }
    public void Devolver()
    {
        Console.WriteLine($"Livro {Titulo} Devolvido!");
    }

}
class Revista : Itembiblioteca, Iemprestimo
{
    int Numeroedicao;
    public Revista(string Titulo, int AnoPublicacao, int Numeroedicao) : base(Titulo, AnoPublicacao)
    {
        this.Numeroedicao = Numeroedicao;
    }
    public override void ExibeInfo()
    {
        Console.WriteLine($"Numero da edicção : {Numeroedicao}");
    }
    public void Emprestar()
    {
        Console.WriteLine($"Revista {Titulo} emprestado!");
    }
    public void Devolver()
    {
        Console.WriteLine($"Revista {Titulo} Devolvido!");
    }

}

public interface Iemprestimo
{
    void Emprestar();
    void Devolver();
}


class Program
{
    static void Main(string[] args)
    {
        Livro meuLivro = new Livro("Dom Casmurro", 1899, "Machado de Assis");
        meuLivro.ExibeInfo();
        meuLivro.Emprestar();
        meuLivro.Devolver();

    }
}