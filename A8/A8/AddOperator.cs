namespace A8;

public class AddOperator : BinaryOperator
{
    public AddOperator(TextReader reader)
    {
        this.LHS= BinaryOperator.GetNextExpression(reader);
        this.RHS = BinaryOperator.GetNextExpression(reader);
        
    }

    public override string OperatorSymbol => "+";

    public override double Evaluate() =>
        this.LHS.Evaluate() + this.RHS.Evaluate();
}
