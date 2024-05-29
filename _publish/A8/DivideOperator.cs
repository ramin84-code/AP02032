namespace A8;
public class DivideOperator : BinaryOperator
{
    public DivideOperator(TextReader reader)
    {
        throw new NotImplementedException();
    }

    public override string OperatorSymbol => throw new NotImplementedException();

    public override double Evaluate() => this.RHS.Evaluate()/ this.LHS.Evaluate();
}