using System.Collections.Generic;

namespace Recall;

public class MainWindowViewModel
{
    public List<string> TestData { get; set; } = GetData();

    public static List<string> GetData()
    {
        return new List<string>
        {
            "Foo",
            "Bar"
        };
    }
}