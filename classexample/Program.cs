namespace classexample;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Person p= new Person();
        p.setName("Lupe");
        Console.WriteLine(p.getName());
        p.Town="Oviedo";
        Console.WriteLine(p.Town);
        p.Age=39;
        Console.WriteLine(p.Age);

        Person p1=new Person("Arancha");
        p1.Town="Gijon";
        p1.Age=40;
        Console.WriteLine($"Se llama {p1.getName()}, vive en {p1.Town} y tiene {p1.Age} años.");
        Console.WriteLine(p1.Greatings());
        Console.WriteLine(p1.Greatings("Pepe"));
    }
}
