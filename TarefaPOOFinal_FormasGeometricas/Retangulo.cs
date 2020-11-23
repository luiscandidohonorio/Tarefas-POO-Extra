namespace CalcAreaPOO
{
    public class Retangulo : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;
    }
}