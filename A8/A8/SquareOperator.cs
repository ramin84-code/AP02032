namespace A8;
public class SquareOperator : UnaryOperator
{
    public SquareOperator(TextReader reader)
    {
        this.Operand = BinaryOperator.GetNextExpression(reader);
    }

    public override string OperatorSymbol => "Square";

    public override double Evaluate() => Math.Pow(this.Operand.Evaluate(),2);

}
