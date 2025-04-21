namespace conexiones;
using System;
using Microsoft.Data.SqlClient;
class Program
{
    static string cadenaConexion="Server=CANTABRICO04\\SQLEXPRESS;"+
                                "Database=Conexion;"+
                                "trusted_connection=True;"+
                                "Encrypt=False";
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Consultar();
        Insertar();
        //Modificar();
    }
    
    static void Consultar()
    {
        using (SqlConnection conexion= new SqlConnection(cadenaConexion))
        //el bloque using establece la conexión con la BBDD
        //ventaja: cierra automaticamente la conexión
        
        {
            conexion.Open();
            string consulta="select * from nombres";
            using (SqlCommand comando=new SqlCommand(consulta,conexion)) //Sin ";"
            using (SqlDataReader lector = comando.ExecuteReader())
            //SqlDatReader crea un objeto en memoria en la BBDD
            {
                Console.WriteLine("Registros actuales");
                while(lector.Read())
                {
                    Console.WriteLine($"ID: {lector["id"]}, Nombre: {lector["nombre"]}, Población: {lector["poblacion"]}, Edad: {lector["edad"]}");
                }
            }
        }
    }
    static void Insertar()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()!;
        Console.Write("Poblacion: ");
        string poblacion = Console.ReadLine()!;
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
            conexion.Open();
            string consulta = "INSERT INTO nombres (nombre, poblacion, edad) VALUES (@nombre, @poblacion, @edad)";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@poblacion", poblacion);
                comando.Parameters.AddWithValue("@edad", edad);

                int filas = comando.ExecuteNonQuery();
                Console.WriteLine($"✔ Se insertó {filas} registro(s).");
            }
        }
    }
    
    static void Modificar()
    {
        Console.Write("ID del registro a modificar: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Nuevo nombre: ");
        string nombre = Console.ReadLine()!;
        Console.Write("Nueva poblacion: ");
        string poblacion = Console. ReadLine()!;
        Console.Write("Nueva edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
            conexion.Open();
            string consulta = "UPDATE nombres SET nombre = @nombre, poblacion = @poblacion, edad = @edad WHERE id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id", id); //no lo actualizamos pero lo necesitaremos para hacer la consulta
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@poblacion", poblacion);
                comando.Parameters.AddWithValue("@edad", edad);

                int filas = comando.ExecuteNonQuery();
                Console.WriteLine($"✔ Se insertó {filas} registro(s).");
            }
        }


    }
}
