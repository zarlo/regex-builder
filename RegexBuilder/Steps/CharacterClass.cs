using System.Text;

namespace RegexBuilder.Steps;

public class CharacterClass : IRegexStep
{
    string[]? items;
    public CharacterClass(params string[] items)
    {
        this.items = items;
    }

    Builder? Builder;

    public CharacterClass(Action<Builder> func)
    {
        this.Builder = new();
        func(this.Builder);
    }

    public string Build()
    {
        StringBuilder sb = new();
        sb.Append("[");
        if(Builder is null)
        foreach (var item in items)
        {
            sb.Append(item);
        }
        if(items is null)
            sb.Append(Builder.Build());
        sb.Append("]");
        return sb.ToString();
    }
}
