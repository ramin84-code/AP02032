namespace A8;
public class SubtractOperator : BinaryOperator
{
    public SubtractOperator(TextReader reader)
    {
        this.LHS = Expression.GetNextExpression(reader);
        this.RHS = Expression.GetNextExpression(reader);
    }

    public override string OperatorSymbol => "-";

    public override double Evaluate() => (this.LHS.Evaluate()- this.RHS.Evaluate());
}
