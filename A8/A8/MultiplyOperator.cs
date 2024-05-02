namespace A8;
public class MultiplyOperator : BinaryOperator
{
    public MultiplyOperator(TextReader reader)
    {
        this.LHS = BinaryOperator.GetNextExpression(reader);
        this.RHS = BinaryOperator.GetNextExpression(reader);
    }

    public override string OperatorSymbol => "*";

    public override double Evaluate() => this.RHS.Evaluate() *this.LHS.Evaluate();
}
