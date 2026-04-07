namespace Programa01;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "", edadTexto = "";
        int edad = 0;
        double estatura = 0.0;

        Console.WriteLine("======= [SISTEMA DE REGISTRO DE USUARIO ] =======\n\n");
        Console.WriteLine("1. Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("\n2. Ingrese su edad: ");
        edadTexto = Console.ReadLine();
        edad = int.Parse(edadTexto);

        Console.WriteLine("\n3. Ingresar estatura (Ej.: 1,75): ");
        estatura = double.Parse(Console.ReadLine());

        Console.WriteLine("\n\n ========= [ PERFIL CREADO] ========= ");
        Console.WriteLine("\nNombre: " + nombre);
        Console.WriteLine("Edad el proximo año: " + (edad + 1));
        Console.WriteLine("Estatura: " + estatura + " metros.");

        Console.WriteLine("\n\nPresina ENTER para salir.");
        Console.ReadLine();
    }
}
