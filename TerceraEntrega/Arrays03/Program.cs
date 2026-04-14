namespace Arrays03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n --- EJERCICIO 3: USO DE .LENGHT Y BUCLE FOR ---");

        // Ejercicio 3.1 

        //INICIALIZACION DIRECTA 
        int[] edades = { 15, 22, 30, 18, 25 };

        //obtener el tamaño del arreglo dinamicamente
        int cantidadElementos = edades.Length;
        Console.WriteLine("El arreglo tiene '" + cantidadElementos + "' elementos");
        Console.WriteLine("----------------------------------------------");

        //iteracion clasica usando indices

        for (int i = 0; i < edades.Length; i++)
        {
            Console.WriteLine("La edad en la posicion " + i + " es: " + edades[i]);
        }

        ContinuarApp();

        // Ejercicio 3.2

        double[] precios = { 1200.5, 850.0, 430.75, 999.99 };
        double total = 0;

        Console.WriteLine("\n-- LISTADO DE PRECIOS --");
        for (int i = 0; i < precios.Length; i++)
        {
            Console.WriteLine((i + 1) + ". $ " + precios[i]);
            total += precios[i];
        }

        double promedio = total / precios.Length;

        Console.WriteLine("\n\nTotal: $" + total);
        Console.WriteLine("Promedio: $" + promedio);

        ContinuarApp();

        // Ejercicio 3.3
        int[] numeros = { 3, 8, 15, 20, 7, 10 };

        int pares = 0;
        int impares = 0;
        
        Console.WriteLine(" -- LISTADO DE NUMEROS --");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + numeros[i]);
            if (numeros[i] % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("\n\nCantidad de pares: " + pares);
        Console.WriteLine("Cantidad de impares: " + impares);

        ContinuarApp();

        // Ejercicio 3.4
        string[] palabras = { "Hola", "Mundo", "CSharp", "Programacion" };

        Console.Write("Ingrese una palabra: ");
        string buscar = Console.ReadLine();

        bool encontrada = false;

        for (int i = 0; i < palabras.Length; i++)
        {
            if (palabras[i].Equals(buscar))
            {
                Console.WriteLine("Palabra encontrada en la posicion: " + i);
                encontrada = true;
                break;
            }
        }

        if (!encontrada)
        {
            Console.WriteLine("No se encontró la palabra.");
        }

        ContinuarApp();

        // Ejercicio 3.5
        int[] listaNumeros = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Array original:");

        for (int i = 0; i < listaNumeros.Length; i++)
        {
            Console.Write(listaNumeros[i] + " ");
        }

        Console.WriteLine("\nArray invertido:");

        for (int i = listaNumeros.Length - 1; i >= 0; i--)
        {
            Console.Write(listaNumeros[i] + " ");
        }

        CloseApp();
    }

    static void ContinuarApp()
    {
        Console.WriteLine("\n\nPresiones 'ENTER' para continuar la aplicación.");
        Console.ReadKey();
    }

    static void CloseApp()
    {
        Console.WriteLine("\n\nPresione 'ENTER' para cerrar la aplicación");
        Console.ReadKey();
    }
}