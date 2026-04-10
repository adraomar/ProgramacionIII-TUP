namespace Programa03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Volumen (double)
            double pesoProducto = 247.35;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Peso del producto (KG): " + pesoProducto + " KG");

            // Dinero (decimal)
            decimal precioProducto = 55200.75m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Precio del producto: $ " + precioProducto);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        } 
    }
}