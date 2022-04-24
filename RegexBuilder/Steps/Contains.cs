namespace RegexBuilder.Steps;

public class Contains : IRegexStep
{

    string[] contains;

    internal Contains(string[] contains)
    {
        this.contains = contains;
    }

    public string Build()
    {
        return String.Join('|', contains);
    }
}
