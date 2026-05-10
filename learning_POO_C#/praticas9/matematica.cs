using System;

namespace math;

class Matematica
{   
    public void Multiplicar( int x, int y)
    {
        Console.WriteLine(x * y);
    } 
    public void Multiplicar(int x, int y, int z)
    {
        Console.WriteLine(x * y * z);
    }
    public void Multiplicar(double x, double y)
    {
        Console.WriteLine(x * y);
    }


}
class Program
{
    static void Main(string[] args)
    {
        Matematica math = new Matematica();

        math.Multiplicar( 3.0, 4.5);
        math.Multiplicar(4 , 5);
        math.Multiplicar(4,6,3);
    }
}



   
