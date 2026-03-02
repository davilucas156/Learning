using System;

struct Livro
{
    public string titulo;
    public string autor;
    public string genero;
    public int ano;
}

class Programa
{
    static Livro CriarLivro(string t, string a, string g, int ano)
    {
        Livro novo;
        novo.titulo = t;
        novo.autor = a;
        novo.genero = g;
        novo.ano = ano;
        return novo;
    }

    static bool EhModernismo(Livro l)
    {
        return l.ano >= 1930 && l.ano <= 1945;
    }

    static bool EhBarroco(Livro l)
    {
        return l.ano >= 1601 && l.ano <= 1768;
    }

    static void Main()
    {
        Livro l1 = CriarLivro("Memórias", "Autor X", "Drama", 1935);
        
        Console.WriteLine("Título: " + l1.titulo);
        Console.WriteLine("Modernismo: " + EhModernismo(l1));
        Console.WriteLine("Barroco: " + EhBarroco(l1));
    }
}