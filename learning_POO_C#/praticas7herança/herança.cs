using System;
using System.Collections.Generic;

namespace herança;
class Produto
{
  protected string nome;
  protected double preco;

  public Produto(string nome, double preco)
  {
    this.nome = nome;
    this.preco = preco;
  }

  public void ExibirDados()
  {
    Console.WriteLine(nome + " - R$" + preco);
  }
}

class Livro : Produto
{
  protected string autor;

  public Livro(string nome, double preco, string autor) : base(nome, preco)
  {
    this.autor = autor;
  }

  public void ExibirDadosLivro()
  {
    Console.WriteLine(nome + " - R$" + preco + " - Autor: " + autor);
  }
}

class Programando{
  static void Main(string[] args)
  {
    Livro book = new Livro("Sapiens", 100, "harari");
    book.ExibirDadosLivro();
    book.ExibirDados();
  }
}
