using System.Text;

namespace RegexBuilder.Steps;

public class Group : IRegexStep
{

    Builder RegexBuilder;

    internal Group(Action<Builder> func)
    {
        this.RegexBuilder = new();
        func(RegexBuilder);

    }

    public string Build()
    {
        return $@"({RegexBuilder.Build()})";
    }
}
