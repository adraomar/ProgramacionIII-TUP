namespace Programa_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            string nombres = "Omar Alberto";
            string apellido = "Adra";
            Console.WriteLine("   Nombres y apellido: " + nombres + " " + apellido);

            // Carácter único (char) - Comillas simples ''
            char inicialNombre = 'O';
            char inicialSegNombre = 'A';
            char inicialApellido = 'A';
            Console.WriteLine("   Inicial nombre: '" + inicialNombre + "'");
            Console.WriteLine("   Inicial segundo nombre: '" + inicialSegNombre + "'");
            Console.WriteLine("   Inicial apellido: '" + inicialApellido + "'");


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}