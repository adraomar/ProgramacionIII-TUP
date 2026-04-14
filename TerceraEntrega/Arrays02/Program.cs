namespace Arrays02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n--- EJERCICIO2: INICILIZACION DIRECTA Y FOREACH ---");

        // Ejercicio 2.1
        string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };
        int contador = 1;

        Console.WriteLine("\n -- LISTADO DE FRUTAS --");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(contador + ". " + fruta);
            contador++;
        }

        ContinuarApp();

        // Ejercicio 2.2
        string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        Console.WriteLine("\n -- DÍAS DE LA SEMANA --");
        foreach (string dia in semana)
        {
            Console.WriteLine("" + dia);
        }

        ContinuarApp();

        // Ejercicio 2.3
        int[] numeros = { 12, 45, 7, 30, 22 };

        int mayor = numeros[0];
        int menor = numeros[0];
        int suma = 0;
        double promedio = 0.0;

        foreach (int num in numeros)
        {
            if (num > mayor)
                mayor = num;

            if (num < menor)
                menor = num;

            suma += num;
        }

        promedio = (double)suma / numeros.Length;

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Promedio: " + promedio);

        ContinuarApp();

        // Ejercicio 2.4
        float[] notas = { 4.5f, 7.0f, 6.2f, 3.8f, 9.1f };

        int aprobados = 0;
        int desaprobados = 0;

        foreach (float nota in notas)
        {
            Console.Write("Nota: " + nota + " -> ");

            if (nota >= 6)
            {
                Console.WriteLine("Aprobado");
                aprobados++;
            }
            else
            {
                Console.WriteLine("Desaprobado");
                desaprobados++;
            }
        }

        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Desaprobados: " + desaprobados);

        ContinuarApp();

        // Ejercicio 2.5
        int[] edades = { 15, 22, 17, 30, 18, 14, 25 };

        int mayores = 0, menores = 0, sumaEdades = 0, arribaPromedio = 0;
        double promedioEdades = 0.0;

        // Primera pasada
        foreach (int edad in edades)
        {
            Console.WriteLine("Edad: " + edad);

            if (edad >= 18)
                mayores++;
            else
                menores++;

            sumaEdades += edad;
        }

        promedioEdades = (double) sumaEdades / edades.Length;

        Console.WriteLine("\nPromedio: " + promedioEdades);
        Console.WriteLine("Mayores de edad: " + mayores);
        Console.WriteLine("Menores de edad: " + menores);

        foreach (int edad in edades)
        {
            if (edad > promedioEdades)
                arribaPromedio++;
        }

        Console.WriteLine("Personas por encima del promedio: " + arribaPromedio);

        CerrarApp();
    }

    static void ContinuarApp()
    {
        Console.WriteLine("\nPresione 'ENTER' para continuar");
        Console.ReadKey();
    }

    static void CerrarApp()
    {
        Console.WriteLine("\nPresione 'ENTER' para cerrar la aplicación");
        Console.ReadKey();
    }
}