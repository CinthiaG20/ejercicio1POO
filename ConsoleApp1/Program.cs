namespace DefaultNamespace;
// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        Circulo circy = new Circulo(11);
        Console.WriteLine(circy.GetArea(11));
// Should return 380.132711084365.

        Circulo circy1 = new Circulo(4.44);
        Console.WriteLine(circy1.GetPerimeter(4.44));
    }
}

// Should return 27.897342763877365