using System.Text;

namespace RegexBuilder.Steps;

public class StringLiteral : IRegexStep
{

    string Literal;

    internal StringLiteral(string StringLiteral)
    {
        Literal = StringLiteral;
    }

    public string Build()
    {
        return Literal;
    }
}
