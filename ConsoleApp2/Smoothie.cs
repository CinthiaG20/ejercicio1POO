using System.Collections;

namespace Ej2;

public class Smoothie
{
    private ArrayList ingredientes = new ArrayList();
    private string nombre;
	public string Nombre
    {
        get { return nombre;}
        set { nombre = value; }
    }
    public ArrayList AddIngredient(Ingrediente ing)
    {
        if (!ingredientes.Contains(ing))
        {
            ingredientes.Add(ing);
        }

        return ingredientes;
    }

    public double GetTotalPrice()
    {
        double suma = 0;
        foreach (Ingrediente VAR in ingredientes)
        {
            double precio=VAR.Costo;
            suma += precio;
        }

        return suma;
    }

    public string GetFullName()
    {
        string texto = Nombre;
        foreach (Ingrediente VAR in ingredientes)
        {
            texto += " "+VAR.Nombre;
        }

        return texto;
    }

    public Smoothie(string NOMBRE)
    {
        Nombre = NOMBRE;
    }
}