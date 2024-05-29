namespace A8;

public class AddOperator : BinaryOperator
{
    public AddOperator(TextReader reader)
    {
        string s = reader.ReadToEnd();
        string x = null;
        x.Append(s[0]);
        x.Append('+');
        x.Append(s[1]);
    }

    public override string OperatorSymbol => "add";

    public override double Evaluate() =>
        this.LHS.Evaluate() + this.RHS.Evaluate();
}
