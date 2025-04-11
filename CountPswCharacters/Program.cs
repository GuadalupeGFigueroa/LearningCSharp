namespace countpswcharacters;

class Program

/*Escribe un programa que analice una contraseña y cuente 
cuántas letras mayúsculas, minúsculas, 
dígitos y caracteres especiales contiene. 
 */
{
    static void Main(string[] args)
    {
        String password = "Hola@123";
        int upper = 0, lower = 0, digits = 0, specials = 0;
      
        foreach (char c in password)
        {
             if (char.IsUpper(c)) upper++;
            else if (char.IsLower(c)) lower++;  
            else if (char.IsDigit(c)) digits++;
            else specials++;
        }

    Console.WriteLine($"Mayúsculas: {upper}");
    Console.WriteLine($"Minúsculas: {lower}");
    Console.WriteLine($"Dígitos: {digits}");
    Console.WriteLine($"Caractéres especiales: {specials}");

    }
}

