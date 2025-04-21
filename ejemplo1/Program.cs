namespace ejemplo1;

class Program 
{ 
        static void Main(string[] args)
        {
                Persona p =new Persona();
                p.Nombre="Lupe";
                p.Edad=39;
                p.Saludar():
        }
}

public class Persona
{
    //Atributos
    public string Nombre;
    public int Edad;
    //Método

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}