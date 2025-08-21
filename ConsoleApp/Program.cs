// See https://aka.ms/new-console-template for more information
using System.Data;
using System.IO.Pipes;

Console.WriteLine("Hello, World!");

Empresas empresa = new Empresas();
var empresa1 = new Empresas();
Publicas empresa2 = new Publicas();
Empresas empresa3 = empresa2;
Empresas empresa4 =(Empresas)empresa2;
Empresas empresa5 =(Publicas)empresa2;

empresa.Nit =1;
empresa.Nombre = "Colanta";
empresa.Ingresos = 1.65m;
empresa.Activa = false;
empresa.Fecha = DateTime.Now;
empresa.Asociado = new Asociados() {Id = 1, Nombre = "ColMayor"};
empresa.videojuegos = new List<Videojuegos>();
empresa.videojuegos.Add(new Videojuegos() {Id = 1, Nombre = "GTA"});
empresa.videojuegos.Add(new Videojuegos() {Id = 2, Nombre = "DOOM"});

Console.WriteLine(empresa.Nombre);
Console.WriteLine(empresa.Asociado.Nombre);

foreach (var elemento in empresa.videojuegos){

    Console.WriteLine(elemento.Nombre);
}

public class Asociados{

    public int Id;
    public String? Nombre;
}

public class Videojuegos{

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
    public List<Videojuegos>? videojuegos;
    
}

public class Publicas : Empresas{

    public String? Carnet;


}