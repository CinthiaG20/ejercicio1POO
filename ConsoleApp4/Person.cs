namespace ConsoleApp3;

public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string rol;

    public string Rol
    {
        get { return rol; }
        set { rol = value; }
    }
    private string firstProgenitor;

    public string FirstProgenitor
    {
        get { return firstProgenitor; }
        set { firstProgenitor = value; }
    }
    private string secondProgenitor;

    public string SecondProgenitor
    {
        get { return secondProgenitor; }
        set { secondProgenitor = value; }
    }

    public Person(string name,string rol,string firstProgenitor,string secondProgenitor)
    {
        Name = name;
        Rol = rol;
        FirstProgenitor = firstProgenitor;
        SecondProgenitor = secondProgenitor;
    }

    public string GetName()
    {
        return this.name;
    }

    public string ShowFamilyTree()
    {
        return $"{this.name} es {this.rol}.";
    }
}