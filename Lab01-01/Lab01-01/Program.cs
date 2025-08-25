class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string DNI { get; set; }
}

class Empresa
{
    public int Id { get; set; }
    public string RazonSocial { get; set; }
    public string RUC { get; set; }
}

class Auto<TPropietario>
{
    public string Placa { get; set; }
    public string Sede { get; set; }
    public TPropietario Propietario { get; set; }
}

class Program
{
    static void Main()
    {
        var persona = new Persona { Id = 1, Nombre = "Esteban", DNI = "12345678" };
        var empresa = new Empresa { Id = 2, RazonSocial = "Anonimo S.A.", RUC = "19123456789" };

        var autodePersona = new Auto<Persona> { Placa = "ABC123", Sede = "Lima", Propietario = persona };
        var autodeEmpresa = new Auto<Empresa> { Placa = "XYZ789", Sede = "Arequipa", Propietario = empresa };

        Console.WriteLine($"Auto de persona: Placa={autodePersona.Placa}, Propietario={autodePersona.Propietario.Nombre}");
        Console.WriteLine($"Auto de empresa: Placa={autodeEmpresa.Placa}, Propietario={autodeEmpresa.Propietario.RazonSocial}");
    }
}