namespace Encapsulamiento;

class Program
{
    public static void Main(string[] args)
    {
        string? apellido = "", nombres = "";
        string nombreTitular = "";
        int opcion;

        Console.WriteLine("Ingrese su apellido: ");
        apellido = Console.ReadLine();

        Console.WriteLine("Ingrese su nombre: ");
        nombres = Console.ReadLine();

        nombreTitular = apellido + " " + nombres;

        CuentaBancaria cuenta = new CuentaBancaria(nombreTitular, 5000);

        Console.WriteLine("Se ha creado su cuenta correctamente.");

        do
        {
            Console.WriteLine("===== MENÚ CUENTA BANCARIA =====");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Retirar");
            Console.WriteLine("3 - Mostrar historial");
            Console.WriteLine("0 - Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el monto a depositar: ");
                    decimal deposito = Convert.ToDecimal(Console.ReadLine());

                    cuenta.Depositar(deposito);
                    break;

                case 2:
                    Console.Write("Ingrese el monto a retirar: ");
                    decimal retiro = Convert.ToDecimal(Console.ReadLine());

                    cuenta.Retirar(retiro);
                    break;

                case 3:
                    Console.WriteLine("Mostrando historial...");

                    foreach (var hist in cuenta.Historial)
                    {
                        Console.WriteLine(hist);
                    }

                    break;

                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 0);

    }
}