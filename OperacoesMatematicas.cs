namespace HellowWorld;

public class OperacoesMatematicas
{
    public double Valor1 { get; set; }
    public double Valor2 { get; set; }
    public double Soma () => Valor1 + Valor2;
    public double Subtracao() => Valor1 - Valor2;
    public double Multiplicacao() => Valor1 * Valor2;
    public double Divisao() => Valor1 / Valor2;
    public double Media() => (Valor1 + Valor2) / 2.00;

}
