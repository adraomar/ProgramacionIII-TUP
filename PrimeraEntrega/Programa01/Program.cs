namespace Programa01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ======== [ SISTEMA DE REGISTRO DE USUARIOS ] ========\n");

        //Entrada de Texto Simple
        Console.WriteLine("- Ingrese nombre de usuario:");
        string usuario = Console.ReadLine();

        // Entrada de numero entero (Requiere Conversion)
        Console.WriteLine("- Ingrese su contraseña (SOLO NUMEROS ENTEROS): ");
        int password = int.Parse(Console.ReadLine());

        // Entrada de numero decimales (Requiere Conversion)
        Console.WriteLine("- Ingrese su sueldo bruto: ");
        double sueldo = double.Parse(Console.ReadLine());

        Console.WriteLine("\n\n ===== [ CUENTA CREADA ] =====");
        Console.WriteLine("\n Los datos de su cuenta son: ");
        Console.WriteLine(" =================================");
        Console.WriteLine("|| Usuario: " + usuario + " ||");
        Console.WriteLine("|| Contraseña: " + password + " ||");
        Console.WriteLine("|| Sueldo Bruto: $ " + sueldo + " ||");
        Console.WriteLine(" =================================");
        Console.WriteLine("\n\n Presione ENTER para salir.");
        Console.ReadKey();
    }
}
