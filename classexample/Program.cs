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
    }
}
