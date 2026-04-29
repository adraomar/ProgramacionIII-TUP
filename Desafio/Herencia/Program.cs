namespace Herencia;

class Program
{
    public static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        empleados.Add(new EmpleadoTiempoCompleto("Omar Alberto Adra", 55900, 1200000));
        empleados.Add(new EmpleadoPartTime("Braian Barrionuevo", 56000, 80, 1500));
        empleados.Add(new EmpleadoContratado("Pablo Arancibia", 57000, 95000, new DateTime(2026, 12, 31)));

        decimal costoTotalNomina = 0m;

        foreach (Empleado e in empleados)
        {
            e.MostrarInfo();
            costoTotalNomina += e.CalcularSueldo();
        }

        Console.WriteLine("\n==============================");
        Console.WriteLine("Costo total de nómina: $" + costoTotalNomina);
        Console.WriteLine("==============================");
    }
}