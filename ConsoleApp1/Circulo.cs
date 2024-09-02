namespace DefaultNamespace;

public class Circulo
{
    private double radio;

    public double Radio
    {
        set { radio = value; }
    }

    public Circulo(double radio)
    {
        this.Radio = radio;
    }

    public double GetPerimeter(double radio)
    {
        double perimetro = 2 * radio * 3.14;
        return perimetro;
    }

    public double GetArea(double radio)
    {
        double Area = 3.14 * (radio * radio);
        return Area;
    }
}
