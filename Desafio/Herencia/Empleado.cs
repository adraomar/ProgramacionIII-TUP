namespace Herencia;

abstract class Empleado
{
    protected string nombre;
    protected int legajo;
    protected decimal sueldoBase;

    public Empleado(string nombre, int legajo, decimal sueldoBase)
    {
        this.nombre = nombre;
        this.legajo = legajo;
        this.sueldoBase = sueldoBase;
    }

    public abstract decimal CalcularSueldo();

    public virtual void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Legajo: " + legajo);
        Console.WriteLine("Sueldo total mensual: " + CalcularSueldo());
    }
}