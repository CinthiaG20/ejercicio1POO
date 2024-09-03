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
	public ArrayList Ingrediente(){
	ArrayList lista=new ArrayList();
	lista.Add(nombre)
	lista.Add(costo)
}
}