using System.Text;

namespace RegexBuilder.Steps;

public class ExactMatch : IRegexStep
{

    Builder RegexBuilder;

    internal ExactMatch(Action<Builder> func)
    {
        this.RegexBuilder = new();
        func(this.RegexBuilder);

    }

    public string Build()
    {
        return $@"^{RegexBuilder.ToString()}$";
    }
}
