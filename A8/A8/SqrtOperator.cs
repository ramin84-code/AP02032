namespace A8;
public class SqrtOperator : UnaryOperator
{
    public SqrtOperator(TextReader reader)
    {
        this.Operand = UnaryOperator.GetNextExpression(reader);
    }

    public override string OperatorSymbol => "Sqrt";

    public override double Evaluate() => Math.Sqrt(this.Operand.Evaluate());
}
