class Millas
{
    public double Valor { get; set; }

    public Millas(double valor)
    {
        Valor = valor;
    }

    public double A_Kilometros()
    {
        return Valor * 1.60934;
    }
}