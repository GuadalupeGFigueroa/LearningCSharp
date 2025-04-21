namespace ejemplo15;

class Program
{
    static void Main(string[] args)
    {
        //Ejemplo 1
        Console.WriteLine("Hello, Lupe!");

        //Ejemplo 2
        Console.Write("Hola");
        Console.Write("Lupe");
        
        //Ejemplo 3
        string nombre = "Lupe";
        Console.WriteLine("Hola, "+ nombre + "!");
        
        //Ejemplo 4
        string otroNombre= "Lupe";
        int edad = 39;
        Console.WriteLine($"Mi nombre es {otroNombre} y tengo {edad} años.");

        //Ejemplo 5
        Console.WriteLine("Primera línea\nSegunda línea");

        //Ejemplo 6
        double precio = 1234.56789;
        Console.WriteLine($"El precio es : {precio:F2}");
    }
}
