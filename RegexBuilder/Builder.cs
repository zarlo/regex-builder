using System.Text;
using System.Text.RegularExpressions;

namespace RegexBuilder;

public class Builder
{

    public List<IRegexStep> Steps = new();


    public string Build(bool test = false)
    {
        StringBuilder sb = new();
        foreach (var item in Steps)
        {
            sb.Append(item.Build());
        }
        var output = sb.ToString();
        if(test)
        {
            // jut just checks if its a valid regex string
            Regex.Match("", output);
        }
        return output;
    }

    public Builder Clone()
    {
        return new Builder() {
            Steps = this.Steps
        };
    }

}
