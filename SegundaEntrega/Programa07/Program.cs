namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        const char SIMBOLO_PESO = '$';

        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const decimal TASA_IVA = 0.21m; // 21% fijo
        const bool MODO_PRUEBA = false; // Control de seguridad

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();

        //---------------------------------------------------------------------------------

        //Ejercicio 2
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const decimal PRECIO_LITRO = 1.45m; // Precio fijo por litro
        const bool SURTIDOR_CONECTADO = true; // Control de seguridad
        const char UNIDAD_MEDIDA = 'L';

        Console.WriteLine("--- MÓDULO DE COMBUSTIBLE ---");
        Console.WriteLine("Surtidor operativo: " + SURTIDOR_CONECTADO);

        decimal litrosCargados = 45.50m;
        decimal subtotalSinIva = litrosCargados * PRECIO_LITRO;
        decimal totalConTasaExtra = subtotalSinIva + 2.50m; // Sumamos un cargo fijo de servicio

        Console.WriteLine("\nDetalle de carga:");
        Console.WriteLine("Cantidad: " + litrosCargados + UNIDAD_MEDIDA);
        Console.WriteLine("Precio por unidad: " + PRECIO_LITRO);
        Console.WriteLine("TOTAL A PAGAR: " + totalConTasaExtra);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();

        //---------------------------------------------------------------------------------

        //Ejercicio 3

        const decimal APORTE_INICIAL = 7600m; // Precio fijo por inicio de juicio
        const decimal TASA_INTERES = 0.005m; // Interés fijo del 0.5%
        const bool ES_ORDINARIO = true; // Control de seguridad

        Console.WriteLine("--- MÓDULO DE BOLETA DE INICIO DE JUICIO ---");
        Console.WriteLine("ES ORDINARIO: " + ES_ORDINARIO);

        decimal montoDemanda = 3459840.00m;
        decimal interesCalculado = montoDemanda * TASA_INTERES;
        decimal totalConTasaExtra1 = APORTE_INICIAL + interesCalculado;


        Console.WriteLine("\nDetalle de carga:");
        Console.WriteLine("Monto de la demanda: " + montoDemanda + SIMBOLO_PESO);
        Console.WriteLine("Precio por unidad: " + APORTE_INICIAL);
        Console.WriteLine("Interés calculado: " + interesCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + totalConTasaExtra1);
        
        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();


        //---------------------------------------------------------------------------------

        //Ejercicio 4
        const decimal PRECIO_ENTRADA = 12.50m; // Precio fijo por entrada
        const bool FUNCION_ACTIVA = true; // Control de seguridad

        Console.WriteLine("--- MÓDULO DE VENTA DE ENTRADAS ---");
        Console.WriteLine("Función activa: " + FUNCION_ACTIVA);

        int cantidadEntradas = 4;
        decimal subtotalSinIva2 = cantidadEntradas * PRECIO_ENTRADA;

        Console.WriteLine("\nDetalle de compra:");
        Console.WriteLine("Cantidad de entradas: " + cantidadEntradas);
        Console.WriteLine("Precio por entrada: " + SIMBOLO_PESO + PRECIO_ENTRADA);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + subtotalSinIva2);

        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();


        //---------------------------------------------------------------------------------

        //Ejercicio 5
        const decimal PRECIO_HORA = 25.00m; // Precio fijo por hora
        const bool MAQUINA_OPERATIVA = true; // Control de seguridad    

        Console.WriteLine("--- MÓDULO DE ALQUILER DE MAQUINARIA ---");
        Console.WriteLine("Máquina operativa: " + MAQUINA_OPERATIVA);

        int horasAlquiladas = 8;
        decimal subtotalSinIva3 = horasAlquiladas * PRECIO_HORA;

        Console.WriteLine("\nDetalle de alquiler:");
        Console.WriteLine("Horas alquiladas: " + horasAlquiladas);
        Console.WriteLine("Precio por hora: " + SIMBOLO_PESO + PRECIO_HORA);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + subtotalSinIva3);
        
        Console.WriteLine("\n\nPresione 'ENTER' para continuar...");
        Console.ReadLine();
    }
}