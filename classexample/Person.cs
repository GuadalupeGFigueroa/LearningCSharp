namespace classexample;

class Person
{
    public Person(string name)
    {
        this.name=name; //Constructor con parámetros
    }

    public Person()
    {
        //Constructor vacío
    }

    private string name;
    private string town;
    //private int age; 
    // No se define la variable "age" porque se establece una propiedad que creará la variable directamente. 

    //Existen 3 formas de acceder a tributos privados.
    //Forma 1: crear dos métodos para acceder al valor, uno para fijarlo y otro para obtenerlo.

    public void setName(string name)
    {
        this.name = name; 
    }
    
    public string getName()
    {
        return name;
    }

    //Forma 2: crear una propiedad con el mismo nombre del campo (con la inicial en mayúscula).
    public string Town
    {
        get 
        { 
            return town;
        }
        set
        {
            town=value;
        }
    }
     // Forma 3: crear propiedad. 
        //Evita definir la variable
    public int Age { get; set; }

    public string Greatings ()
    {
        return $"Hola, soy {getName()}, vivo en {town} y tengo {Age} años";
    }

    public string Greatings (string name)
    {
        return $"Hola, {name}. Soy {getName()}, vivo en {town} y tengo {Age} años";
    }

}