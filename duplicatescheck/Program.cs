namespace duplicatescheck;

class Program
/* Escribe un programa que verifique si un nombre ya está contenido en una lista. 
Si sí está, se muestra mensaje indicando que no debe agregarse.
Si no está, se agrega a la lista.
*/
{
    static void Main(string[] args)
    {
        List<string> names = new List<string> {"Lara", "Susana", "Acacia", "Pilar"};
        string newname = "";
        
        Console.WriteLine("Escribe tu nombre: ");
        newname = Console.ReadLine();

        if (names.Contains(newname))
        {
            Console.WriteLine("El nombre ya está en la lista.");
        }
        else
        {
            names.Add(newname);
            Console.WriteLine($"Se ha añadido el nombre {newname}");
            Console.WriteLine($"La lista actual contiene a las siguientes personas: {string.Join(", ", names)}");

        }

    }
}
