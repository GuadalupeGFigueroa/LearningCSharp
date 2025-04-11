namespace charactercontrol2;

class Program
{
    static void Main(string [] args)
    {
        char caracter = '@';
        Console.WriteLine("Es una letra: " + char.IsLetter(caracter));
        Console.WriteLine("Es mayúscula: " + char.IsUpper(caracter));
        Console.WriteLine("Es minúscula: " + char.IsLower(caracter));
        Console.WriteLine("Es un dígito: " + char.IsDigit(caracter));
        Console.WriteLine("Es un caracter especial: " + !char.IsLetterOrDigit(caracter));
    }
}