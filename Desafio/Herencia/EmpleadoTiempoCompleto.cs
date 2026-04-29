namespace Herencia;

class EmpleadoTiempoCompleto : Empleado
{
    private const decimal bonoAnual = 50000m;
    public EmpleadoTiempoCompleto(string nombre, int legajo, decimal sueldoBase) : base(nombre, legajo, sueldoBase)
    {
        
    }

    public override decimal CalcularSueldo()
    {
        return (sueldoBase + (bonoAnual / 12));
    }

    public override void MostrarInfo()
    {
        Console.WriteLine("\n ====== [ EMPLEADO TIEMPO COMPLETO ] ========= ");
        base.MostrarInfo();
        Console.WriteLine("Bono mensual parroteado: $" + (bonoAnual / 12));
    }

}