namespace Arrays01;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1.1
        Console.WriteLine("===== [EJERCICIO 01: FUNDAMENTOS DE ARREGLSO] =====");

        int[] numeros = new int[3];

        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = -30;

        Console.WriteLine("-- Ejercicio 1.1 --");
        //Console.WriteLine("Intento de acceso a indice 3: " + numeros[3]);

        ContinueApp();

        // Ejercicio 1.2
        string[] animales = new string[5];

        animales[0] = "Perro";
        animales[1] = "Gato";
        animales[2] = "Loro";
        animales[3] = "Tortuga";
        animales[4] = "Hamster";

        Console.WriteLine("-- Ejercicio 1.2 --");

        Console.WriteLine("El resultado del array 'animales' es: ");
        Console.WriteLine("- animales[0]: " + animales[0]);
        Console.WriteLine("- animales[1]: " + animales[1]);
        Console.WriteLine("- animales[2]: " + animales[2]);
        Console.WriteLine("- animales[3]: " + animales[3]);
        Console.WriteLine("- animales[4]: " + animales[4]);

        ContinueApp();

        // Ejercicio 1.3
        const int expMultiplier = 2;
        int[] experiencia = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
        int[] niveles = new int[10];

        niveles[0] = experiencia[0] * expMultiplier;
        niveles[1] = experiencia[1] * expMultiplier;
        niveles[2] = experiencia[2] * expMultiplier;
        niveles[3] = experiencia[3] * expMultiplier;
        niveles[4] = experiencia[4] * expMultiplier;
        niveles[5] = experiencia[5] * expMultiplier;
        niveles[6] = experiencia[6] * expMultiplier;
        niveles[7] = experiencia[7] * expMultiplier;
        niveles[8] = experiencia[8] * expMultiplier;
        niveles[9] = experiencia[9] * expMultiplier;

        Console.WriteLine(" -- LISTA DE NIVELES Y EXPERIENCIA --");
        Console.WriteLine(" Nivel 1: " + niveles[0] + " EXP.");
        Console.WriteLine(" Nivel 2: " + niveles[1] + " EXP.");
        Console.WriteLine(" Nivel 3: " + niveles[2] + " EXP.");
        Console.WriteLine(" Nivel 4: " + niveles[3] + " EXP.");
        Console.WriteLine(" Nivel 5: " + niveles[4] + " EXP.");
        Console.WriteLine(" Nivel 6: " + niveles[5] + " EXP.");
        Console.WriteLine(" Nivel 7: " + niveles[6] + " EXP.");
        Console.WriteLine(" Nivel 8: " + niveles[7] + " EXP.");
        Console.WriteLine(" Nivel 9: " + niveles[8] + " EXP.");
        Console.WriteLine(" Nivel 10: " + niveles[9] + " EXP.");

        ContinueApp();

        // Ejercicio 1.4
        string[] colores = { "Rojo", "Verde", "Azul", "Amarillo", "Cyan", "Blanco" };
        int[] rgbColores = new int[18];

        // Rojo
        rgbColores[0] = 255;
        rgbColores[1] = 0;
        rgbColores[2] = 0;

        // Verde
        rgbColores[3] = 0;
        rgbColores[4] = 255;
        rgbColores[5] = 0;

        // Azul
        rgbColores[6] = 0;
        rgbColores[7] = 0;
        rgbColores[8] = 255;

        // Amarillo
        rgbColores[9] = 255;
        rgbColores[10] = 255;
        rgbColores[11] = 0;

        // Cyan
        rgbColores[12] = 0;
        rgbColores[13] = 255;
        rgbColores[14] = 255;

        // Blanco
        rgbColores[15] = 255;
        rgbColores[16] = 255;
        rgbColores[17] = 255;

        Console.WriteLine("\n -- LISTA DE COLORES RGB --\n");
        Console.WriteLine("\n1. " + colores[0] + " - R: " + rgbColores[0] + " - G: " + rgbColores[1] + " - B: " + rgbColores[2]);
        Console.WriteLine("2. " + colores[1] + " - R: " + rgbColores[3] + " - G: " + rgbColores[4] + " - B: " + rgbColores[5]);
        Console.WriteLine("3. " + colores[2] + " - R: " + rgbColores[6] + " - G: " + rgbColores[7] + " - B: " + rgbColores[8]);
        Console.WriteLine("4. " + colores[3] + " - R: " + rgbColores[9] + " - G: " + rgbColores[10] + " - B: " + rgbColores[11]);
        Console.WriteLine("5. " + colores[4] + " - R: " + rgbColores[12] + " - G: " + rgbColores[13] + " - B: " + rgbColores[14]);
        Console.WriteLine("6. " + colores[5] + " - R: " + rgbColores[15] + " - G: " + rgbColores[16] + " - B: " + rgbColores[17]);

        ContinueApp();

        // Ejercicio 1.5
        string[] productos = { "Teclado", "Monitor", "Mouse", "Auricular", "Procesador" };
        double[] precios = { 150.00, 300.50, 600.75, 1200.30, 2400.60 };

        Console.WriteLine("\n -- LISTA DE PRODUCTOS --\n");
        Console.WriteLine("\n1. " + productos[0] + ": $ " + precios[0]);
        Console.WriteLine("2. " + productos[1] + ": $ " + precios[1]);
        Console.WriteLine("3. " + productos[2] + ": $ " + precios[2]);
        Console.WriteLine("4. " + productos[3] + ": $ " + precios[3]);
        Console.WriteLine("5. " + productos[4] + ": $ " + precios[4]);

        CloseApp();
    }

    static void ContinueApp()
    {
        Console.WriteLine("\n\nPresione 'ENTER' para continuar.\n\n");
        Console.ReadKey();
    }

    static void CloseApp()
    {
        Console.WriteLine("\n\nPresione 'ENTER' para cerrar la aplicación.\n\n");
        Console.ReadKey();
    }
}