class Kilometros
{
    public double Valor { get; set; }

    public Kilometros(double valor)
    {
        Valor = valor;
    }

    public double A_Millas()
    {
        return Valor / 1.60934;
    }
}