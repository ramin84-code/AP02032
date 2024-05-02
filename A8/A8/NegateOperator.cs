namespace A8;
public class NegateOperator : UnaryOperator
{
    public NegateOperator(TextReader reader)
    {
        this.Operand = UnaryOperator.GetNextExpression(reader);
        
    }

    public override string OperatorSymbol => "-";

    public override double Evaluate() => this.Operand.Evaluate() * -1;
}
