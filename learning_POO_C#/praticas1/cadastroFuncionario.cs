using System;

class Funcionario
{
    public int Matricula;
    public string Nome;
    public string Departamento;
    public double Salario;
    public int Dia, Mes, Ano; 
}

class Program
{
    static void Main()
    {
        Funcionario[] vet = new Funcionario[50];

        for (int i = 0; i < 2; i++) 
        {
            vet[i] = new Funcionario();
            Console.WriteLine($"--- Cadastro do Funcionário {i + 1} ---");
            
            Console.Write("Matrícula: ");
            vet[i].Matricula = int.Parse(Console.ReadLine());
            
            Console.Write("Nome: ");
            vet[i].Nome = Console.ReadLine();
            
            Console.Write("Departamento: ");
            vet[i].Departamento = Console.ReadLine();
            
            Console.Write("Salário: ");
            vet[i].Salario = double.Parse(Console.ReadLine());
            
            Console.Write("Dia de Admissão: ");
            vet[i].Dia = int.Parse(Console.ReadLine());
            
            Console.Write("Mês de Admissão: ");
            vet[i].Mes = int.Parse(Console.ReadLine());
            
            Console.Write("Ano de Admissão: ");
            vet[i].Ano = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite o departamento para filtrar:");
        string deptoBusca = Console.ReadLine();

        Console.WriteLine($"\nFuncionários do departamento {deptoBusca}:");
        for (int i = 0; i < 2; i++)
        {
            if (vet[i].Departamento == deptoBusca)
            {
                Console.WriteLine($"- Nome: {vet[i].Nome} | Matrícula: {vet[i].Matricula}");
            }
        }
    }
}