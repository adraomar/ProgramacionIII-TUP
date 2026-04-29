namespace Herencia;

class EmpleadoContratado : Empleado
{
    private DateTime fechaVencimiento;

    public EmpleadoContratado(string nombre, int legajo, decimal sueldoBase, DateTime fechaVencimiento) : base(nombre, legajo, sueldoBase)
    {
        this.fechaVencimiento = fechaVencimiento;
    }

    public override decimal CalcularSueldo()
    {
        return sueldoBase;
    }

    public int DiasParaVencimiento()
    {
        TimeSpan diferencia = fechaVencimiento - DateTime.Now;

        return diferencia.Days;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine("\n ====== [ EMPLEADO CONTRATADO ] ========= ");
        base.MostrarInfo();
        Console.WriteLine("Fecha de vencimiento: " + fechaVencimiento.ToShortDateString());
        Console.WriteLine("Dias restantes: " + DiasParaVencimiento());
    }

}