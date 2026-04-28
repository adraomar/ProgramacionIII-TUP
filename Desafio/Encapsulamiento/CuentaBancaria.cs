namespace Encapsulamiento;

class CuentaBancaria
{
    public string Titular { get; set; }
    private decimal saldo;
    private readonly List<string> historial;

    public decimal Saldo
    {
        get { return saldo; }
    }

    public IReadOnlyList<string> Historial
    {
        get { return historial.AsReadOnly(); }
    }

    public CuentaBancaria(string nombreTitular, decimal saldo = 0)
    {   
        if(saldo < 0) 
            throw new ArgumentException("El sado inicial no puede ser negativo");

        Titular = nombreTitular;
        this.saldo = saldo;
        this.historial = new List<string>();

        historial.Add(FormatHistorial("Se ha creado una nueva cuenta con el saldo inicial de $", saldo));
    }

    public void Depositar(decimal monto)
    {
        if(monto <= 0) throw new ArgumentException("El monto a depositar debe ser mayor a cero.");

        saldo += monto;
        historial.Add(FormatHistorial("Se ha realizado un deposito por $", monto, "- Saldo actual: $", saldo));
    }

    public void Retirar(decimal monto)
    {
        if(monto <= 0) throw new ArgumentException("El monto a retirar debe ser mayor a cero.");
        if(monto > saldo) throw new InvalidOperationException("Saldo insuficiente para relizar el retiro.");

        saldo -= monto;
        historial.Add(FormatHistorial("Se ha relizado un retiro por $", monto, "- Saldo actual: $", saldo));
    }

    public void AplicarInteresMensual()
    {
        decimal interes = saldo * 0.03m;
        saldo += interes;
        historial.Add(FormatHistorial("Interes aplicado (3%): ", interes, "- Saldo actual: ", saldo));
    }

    private string FormatHistorial(string mensaje, params object[] valores)
    {
        if (valores.Length == 0)
            return mensaje;

        return mensaje + " " + string.Join(" ", valores);
    }

}