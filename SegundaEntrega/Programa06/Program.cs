class Program
{
    static void Main(string[] args)
    {
        // --- EJERCICIO 1 ---
        const string MODULO1 = "Módulo de Ventas";
        const string VERSION1 = "v1.0";
        const int EDAD_MINIMA_COMPRA = 18;

        Console.WriteLine("=== " + MODULO1 + " (" + VERSION1 + ") ===");
        Console.WriteLine("Validando reglas de compra...");
        Console.WriteLine("Restricción: Solo mayores de " + EDAD_MINIMA_COMPRA + " años pueden comprar.");

        const int edadCliente = 16;
        const bool puedeComprar = edadCliente >= EDAD_MINIMA_COMPRA;

        Console.WriteLine("\nCliente con edad: " + edadCliente);
        Console.WriteLine("Edad mínima requerida: " + EDAD_MINIMA_COMPRA);
        Console.WriteLine("¿Puede realizar la compra?: " + puedeComprar);

        Console.WriteLine("Módulo: " + MODULO1);
        Console.WriteLine("Versión: " + VERSION1);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();

        //---------------------------------------

        // --- EJERCICIO 2 ---
        const string MODULO2 = "Módulo de Descuentos";
        const string VERSION2 = "v2.0";
        const double MONTO_MINIMO_DESCUENTO = 10000;

        Console.WriteLine("=== " + MODULO2 + " (" + VERSION2 + ") ===");
        Console.WriteLine("Aplicando política de descuentos...");
        Console.WriteLine("Compra mínima para descuento: $" + MONTO_MINIMO_DESCUENTO);

        const double totalCompra = 8500;
        const bool aplicaDescuento = totalCompra >= MONTO_MINIMO_DESCUENTO;

        Console.WriteLine("\nTotal de compra: $" + totalCompra);
        Console.WriteLine("Monto mínimo requerido: $" + MONTO_MINIMO_DESCUENTO);
        Console.WriteLine("¿Tiene descuento?: " + aplicaDescuento);

        Console.WriteLine("Módulo: " + MODULO2);
        Console.WriteLine("Versión: " + VERSION2);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();

        //---------------------------------------

        // --- EJERCICIO 3 ---
        const string MODULO3 = "Módulo de Stock";
        const string VERSION3 = "v1.5";
        const int STOCK_MAXIMO = 100;

        Console.WriteLine("=== " + MODULO3 + " (" + VERSION3 + ") ===");
        Console.WriteLine("Controlando límite de stock...");
        Console.WriteLine("Stock máximo permitido: " + STOCK_MAXIMO);

        const int stockActual = 120;
        const bool superaStock = stockActual > STOCK_MAXIMO;

        Console.WriteLine("\nStock actual: " + stockActual);
        Console.WriteLine("Stock máximo: " + STOCK_MAXIMO);
        Console.WriteLine("¿Supera el límite?: " + superaStock);

        Console.WriteLine("Módulo: " + MODULO3);
        Console.WriteLine("Versión: " + VERSION3);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();

        //---------------------------------------

        // --- EJERCICIO 4 ---
        const string MODULO4 = "Módulo de Atención";
        const string VERSION4 = "v1.2";
        const int HORA_INICIO = 8;
        const int HORA_FIN = 18;

        Console.WriteLine("=== " + MODULO4 + " (" + VERSION4 + ") ===");
        Console.WriteLine("Verificando horario de ventas...");
        Console.WriteLine("Ventas habilitadas de " + HORA_INICIO + ":00 a " + HORA_FIN + ":00");

        const int horaActual = 20;
        const bool ventaHabilitada = horaActual >= HORA_INICIO && horaActual < HORA_FIN;

        Console.WriteLine("\nHora actual: " + horaActual + ":00");
        Console.WriteLine("Horario válido: " + HORA_INICIO + ":00 - " + HORA_FIN + ":00");
        Console.WriteLine("¿Se puede vender?: " + ventaHabilitada);

        Console.WriteLine("Módulo: " + MODULO4);
        Console.WriteLine("Versión: " + VERSION4);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();

        //---------------------------------------

        // --- EJERCICIO 5 ---
        const string MODULO5 = "Módulo de Inventario";
        const string VERSION5 = "v3.0";
        const int PRODUCTOS_EN_STOCK = 50;

        Console.WriteLine("=== " + MODULO5 + " (" + VERSION5 + ") ===");
        Console.WriteLine("Consultando disponibilidad...");
        Console.WriteLine("Productos disponibles: " + PRODUCTOS_EN_STOCK);

        const int productosSolicitados = 60;
        const bool hayStock = productosSolicitados <= PRODUCTOS_EN_STOCK;

        Console.WriteLine("\nProductos solicitados: " + productosSolicitados);
        Console.WriteLine("Stock actual: " + PRODUCTOS_EN_STOCK);
        Console.WriteLine("¿Hay stock suficiente?: " + hayStock);

        Console.WriteLine("Módulo: " + MODULO5);
        Console.WriteLine("Versión: " + VERSION5);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();
    }
}