namespace Programa_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---\n");

            // Cadena de texto (string) - Comillas dobles ""
            string nombres = "Omar Alberto";
            string apellido = "Adra";
            Console.WriteLine("4. TIPO TEXTO (string):");
            Console.WriteLine("- Apellido y Nombre: " + apellido + ", " + nombres);

            // Carácter único (char) - Comillas simples ''
            char iniNombre = 'O';
            char iniSegNombre = 'A';
            char iniApellido = 'A';
            Console.WriteLine("\n5. TIPO CARÁCTER (char):");
            Console.WriteLine("- Codigo de Empleado: " + iniNombre + iniSegNombre + iniApellido);


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
