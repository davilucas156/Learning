using System;
using System.Collections.Generic;

namespace Escolinha
{
    class Aluno
    {
        private string nome;

        public Aluno(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string valor)
        {
            nome = valor;
        }

        public void ImprimeNome()
        {
            Console.WriteLine(this.nome);
        }
    }

    class EscolaDependencia
    {
        public void exibeNome(Aluno aluno)
        {
            Console.WriteLine(aluno.GetNome());
        }
    }

    class EscolaAssociacao
    {
        public Aluno aluno;

        public EscolaAssociacao(Aluno aluno)
        {
            this.aluno = aluno;
        }

        public void ImprimeNome()
        {
            Console.WriteLine(aluno.GetNome());
        }
    }

    class EscolaAgregacao
    {
        private List<Aluno> listaAluno;

        public EscolaAgregacao()
        {
            listaAluno = new List<Aluno>();
        }

        public void adicionaAluno(Aluno NovoAluno)
        {
            listaAluno.Add(NovoAluno);
        }

        public void imprimirLista()
        {
            Console.WriteLine("Lista de Alunos (Agregação):");
            foreach (Aluno i in listaAluno)
            {
                Console.WriteLine(" - " + i.GetNome());
            }
        }
    }

    class EscolaComposicao
    {
        private List<Aluno> listaAluno;

        public EscolaComposicao()
        {
            listaAluno = new List<Aluno>();
        }

        public void adicionaAluno(string nomeAluno)
        {
            listaAluno.Add(new Aluno(nomeAluno));
        }

        public void imprimirLista()
        {
            Console.WriteLine("Lista de Alunos (Composição):");
            foreach (Aluno i in listaAluno)
            {
                Console.WriteLine("  " + i.GetNome());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* --- Parte 1: Dependência --- */
            // EscolaDependencia escoladep = new EscolaDependencia();
            // Aluno alunoDep = new Aluno("Jonas");
            // escoladep.exibeNome(alunoDep);

            /* --- Parte 2: Associação --- */
            // Aluno alunoAssoc = new Aluno("Davi");
            // EscolaAssociacao escolaAssoc = new EscolaAssociacao(alunoAssoc);
            // escolaAssoc.ImprimeNome();

            /* --- Parte 3: Agregação --- */
            // EscolaAgregacao escolaAgreg = new EscolaAgregacao();
            // Aluno a1 = new Aluno("Giulia");
            // Aluno a2 = new Aluno("Cecilia");
            // escolaAgreg.adicionaAluno(a1);
            // escolaAgreg.adicionaAluno(a2);
            // escolaAgreg.imprimirLista();

            /* --- Parte 4: Composição --- */
             EscolaComposicao escolaComp = new EscolaComposicao();
             escolaComp.adicionaAluno("Marcos");
             escolaComp.adicionaAluno("Fernanda");
             escolaComp.imprimirLista();
        }
    }
}