using System;
using System.Collections.Generic;

namespace AlunosHerdados;

class Pessoa
{
    protected string nome ;
    protected int idade ;

    // public void exibedados(string nome, int idade)
    // {
    //     this.nome = nome;
    //     this.idade = idade;
    // }
    class Aluno : Pessoa
    {
        protected string curso;
        protected int matricula;

        public Aluno(string nome, int idade, string curso, int matricula)
        {
            this.nome = nome;
            this.idade = idade;
            this.curso = curso;
            this.matricula = matricula;
        }

        public void exibirDadosAluno()
        {
            Console.WriteLine($"exibindo dados do aluno: {nome}, {idade}, {curso}, {matricula}");
        }
    }

    class Working
    {
        static void Main (string [] args)
        {
            Aluno aluno1 = new Aluno("davi", 23, "ads" , 20268);

            aluno1.exibirDadosAluno();
        }
    }
}