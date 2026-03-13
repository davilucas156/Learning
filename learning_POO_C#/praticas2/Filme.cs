using System;

class Q2
{
    class Filme
    {
        public string nome;
        public string diretor;
        public int anoLancamento;
        public bool emprestado = false;

        public void exibirInformacoesFIlme()
        {
            Console.WriteLine($"TITULO {nome}, diretor: {diretor}, ano lançado{anoLancamento}, emprestado: {emprestado}");
        }
        public bool EmprestarFilme()
        {
            if (this.emprestado == false)
                return false;
            Console.WriteLine("este filme está indisponível");

            return this.emprestado = false;
        }
        public void DevolverFilme()
        {
            if (this.emprestado == true)
             Console.WriteLine("este filme ja foi devolvido");

            else
             this.emprestado = true;
        }
    }


    class TesteFilme
    {

        static void Main(string[] args)
        {
            Filme[] listaFilme = new Filme[10];
            int contador = 0;
            string respostaMaisUm = "sim";

            do
            {
                listaFilme[contador] = new Filme();

                Console.WriteLine("escreva o nome do filme");
                listaFilme[contador].nome = Console.ReadLine();
                Console.WriteLine("nome do diretor");
                listaFilme[contador].diretor = Console.ReadLine();
                Console.WriteLine("ano de lancamento");
                listaFilme[contador].anoLancamento = int.Parse(Console.ReadLine());
                Console.WriteLine("deseja adicionar mais um filme? digite 'sim' se quiser adicionar ou 'nao' se nao quiser");
                respostaMaisUm = Console.ReadLine();

                contador++;

            } while (respostaMaisUm == "sim" && contador <10);
        }
    }

}