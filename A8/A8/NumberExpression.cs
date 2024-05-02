namespace A8;
public class NumberExpression : Expression
{
    protected double Number;

    public NumberExpression(string line)
    {
        double.TryParse(line, out this.Number);
    }

    public override double Evaluate() => this.Number;

    public override string ToString() => this.Number.ToString();
}
