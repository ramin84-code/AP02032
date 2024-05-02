using System;
using System.IO;

namespace A8;
public abstract class BinaryOperator : Expression, IOperator
{
    protected Expression LHS;
    protected Expression RHS;
    
    public BinaryOperator(TextReader reader)
    {
        this.LHS = BinaryOperator.GetNextExpression(reader);
        this.RHS = BinaryOperator.GetNextExpression(reader);
    }

    public BinaryOperator(){
        
    }

    public abstract string OperatorSymbol { get; }

    public sealed override string ToString() =>$"({this.LHS}{OperatorSymbol}{this.RHS})";

}
