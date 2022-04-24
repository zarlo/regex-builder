using System.Text;

namespace RegexBuilder.Steps;

public class Count : IRegexStep
{

    int max;
    int? min;


    internal Count(int max, int? min = null)
    {
        this.max = max;
        this.min = min;
    }

    public string Build()
    {
        StringBuilder sb = new();
        sb.Append("{");
        if(min.HasValue)
        {
            sb.Append(min.ToString());    
        }
        sb.Append(",");
        sb.Append(max.ToString());
        sb.Append("}");
        return sb.ToString();
    }
}
