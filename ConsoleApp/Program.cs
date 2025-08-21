// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

Empresas empresa = new Empresas();
empresa.Nit =1;
empresa.Nombre = "Colanta";
empresa.Ingresos = 1.65m;
empresa.Activa = false;
empresa.Fecha = DateTime.Now;
empresa.Asociado = new Asociados() {Id = 1, Nombre = "ColMayor"};

public class Asociados{

    public int Id;
    public String? Nombre;
}

public class Empresas{

    public int Nit;
    public String? Nombre;
    public decimal Ingresos;
    public Boolean Activa;
    public DateTime Fecha;
    public Asociados? Asociado;
    
}

public class Publicas : Empresas{

    public String? Carnet;


}