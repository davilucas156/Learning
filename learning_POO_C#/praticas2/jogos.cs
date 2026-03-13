using System;

public class Jogo
{
    public string titulo;
    public string plataforma;
    public int anoLancamento;
    public bool emprestado;

    public Jogo(string titulo, string plataforma, int anoLancamento)
    {
        this.titulo = titulo;
        this.plataforma = plataforma;
        this.anoLancamento = anoLancamento;
        this.emprestado = false;
    }

    public void exibirInformacoes()
    {
        string status = emprestado ? "Emprestado" : "Disponível";
        Console.WriteLine($"Título: {titulo} | Plataforma: {plataforma} | Ano: {anoLancamento} | Status: {status}");
    }

    public void emprestar()
    {
        if (!emprestado)
        {
            emprestado = true;
            Console.WriteLine($"O jogo '{titulo}' foi emprestado com sucesso.");
        }
        else
        {
            Console.WriteLine($"O jogo '{titulo}' já está ocupado.");
        }
    }

    public void devolver()
    {
        if (emprestado)
        {
            emprestado = false;
            Console.WriteLine($"O jogo '{titulo}' foi devolvido.");
        }
        else
        {
            Console.WriteLine($"O jogo '{titulo}' já estava disponível.");
        }
    }



    public class TesteJogo
    {
        public static void Main()
        {
            Console.Write("Quantos jogos deseja cadastrar? ");
            int qtd = int.Parse(Console.ReadLine());

            Jogo[] biblioteca = new Jogo[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"\nCadastro do Jogo {i + 1}:");
                Console.Write("Título: ");
                string t = Console.ReadLine();
                Console.Write("Plataforma: ");
                string p = Console.ReadLine();
                Console.Write("Ano: ");
                int a = int.Parse(Console.ReadLine());

                biblioteca[i] = new Jogo(t, p, a);
            }

            Console.WriteLine("\n--- Lista de Jogos ---");
            foreach (Jogo j in biblioteca)
            {
                j.exibirInformacoes();
            }

            if (biblioteca.Length > 0)
            {
                Console.WriteLine("\n--- Testando Empréstimo e Devolução (Jogo 1) ---");
                biblioteca[0].emprestar();
                biblioteca[0].exibirInformacoes();
                biblioteca[0].devolver();
                biblioteca[0].exibirInformacoes();
            }
        }
    }
}