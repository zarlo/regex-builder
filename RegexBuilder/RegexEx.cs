using System.Text;

namespace RegexBuilder;

public static class RegexEx
{

    public static Builder Contains(this Builder self, params string[] contains)
    {
        self.Steps.Add(new Steps.Contains(contains));
        return self;
    }

    public static Builder StringLiteral(this Builder self, params string[] @string)
    {
        StringBuilder sb = new();
        foreach (var item in @string)
        {
            sb.Append(item);
        }
        self.Steps.Add(new Steps.StringLiteral(sb.ToString()));
        return self;
    }

    public static Builder StringLiteral(this Builder self, string @string)
    {
        self.Steps.Add(new Steps.StringLiteral(@string));
        return self;
    }

    public static Builder Count(this Builder self, int max)
    {
        self.Steps.Add(new Steps.Count(max, null));
        return self;
    }

    public static Builder Count(this Builder self, int min, int max)
    {
        self.Steps.Add(new Steps.Count(max, min));
        return self;
    }

    public static Builder Group(this Builder self, Action<Builder> func)
    {
        self.Steps.Add(new Steps.Group(func));
        return self;
    }

    public static Builder ExactMatch(this Builder self, Action<Builder> func)
    {
        self.Steps.Add(new Steps.ExactMatch(func));
        return self;
    }

    public static Builder CharacterClass(this Builder self, params string[] items)
    {
        self.Steps.Add(new Steps.CharacterClass(items));
        return self;
    }

    public static Builder CharacterClass(this Builder self, Action<Builder> func)
    {
        self.Steps.Add(new Steps.CharacterClass(func));
        return self;
    }

}
