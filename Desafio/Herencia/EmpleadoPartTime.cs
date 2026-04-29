namespace Herencia;

class EmpleadoPartTime : Empleado
{
    private int horasMes;
    private decimal valorHora;

    public EmpleadoPartTime(string nombre, int legajo, int horasMes, decimal valorHora) : base(nombre, legajo, 0)
    {
        this.horasMes = horasMes;
        this.valorHora = valorHora;
    }

    public override decimal CalcularSueldo()
    {
        return horasMes * valorHora;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine("\n ====== [ EMPLEADO MEDIO TIEMPO ] ========= ");
        base.MostrarInfo();
        Console.WriteLine("Horas trabajadas: $" + horasMes);
        Console.WriteLine("Valor por hora: " + valorHora);
    }
}