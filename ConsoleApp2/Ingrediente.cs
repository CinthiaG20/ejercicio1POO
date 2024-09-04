namespace Ej2;
using System.Collections;
public class Ingrediente
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private double costo;

    public double Costo
    {
        get { return costo; }
        set { costo = value; }
    }
	public Ingrediente(string NOMBRE, double COSTO)
    {
        Nombre = NOMBRE;
        Costo = COSTO;
    }
}