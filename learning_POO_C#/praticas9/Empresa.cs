using System;

namespace Empresa
{
    
    class Funcionario
    {
        private string NomeFunc;
        public virtual void ExibirDados()
        {
            Console.WriteLine("Funcionário cadastrado no sistema");
        }
    }

    class Gerente : Funcionario
    {
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine("O gerente também é responsável por liderar a equipe");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gerente meuGerente = new Gerente();
            meuGerente.ExibirDados();
            Console.ReadLine();
        }
    }
}