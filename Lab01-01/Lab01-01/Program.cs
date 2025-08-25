class Persona
{
    private string nombre;
    private int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona(nombre: "Carlos", edad: 25);
        persona1.MostrarInformacion();
    }
}