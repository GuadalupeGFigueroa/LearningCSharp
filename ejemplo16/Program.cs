namespace ejemplo16;

class Program
{
    static void Main(string[] args)
    {
        //Leer una cadena
        Console.WriteLine("Introduce tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola,{nombre}!");
        //Leer un número entero
        Console.Write("Introduce tu edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Writeline($"Tienes {edad} años.");

        //Leer un número decimal
        
    }
}
