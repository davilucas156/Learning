using System; 


namespace automoveis
{
       class Veiculo
    {
        protected  string nome;
        public virtual void Mover()
        {
            Console.WriteLine("O veiculo esta se movendo");
        }
    } 
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("o carro esta dirigindo na estrada");
        }

    }
    class Bicicleta : Veiculo
    {
          public override void Mover()
        {
            Console.WriteLine("A bicicleta esta sendo pedalada");
        }
    }

    class Program
    {
        static void Main(string [] args)
        {
            Veiculo V1 = new Veiculo();
            V1.Mover();

            Carro C1 = new Carro();
            C1.nome = "cadillac";
            C1.Mover();

            Bicicleta bike = new Bicicleta();
            bike.Mover();
        }
    }

}