using System.Collections;

namespace ConsoleApp5;

public class Bank
{
    private ArrayList Clientes;

    public ArrayList clientes
    {
        get { return Clientes; }
        set { Clientes = value; }
        
    }

    public Bank(Account cuenta)
    {
        this.Clientes = this.Clientes.Add(cuenta);
    }

    public ArrayList AddCuenta(Account cuenta)
    {
        this.Clientes.Add(cuenta);
    }
}
