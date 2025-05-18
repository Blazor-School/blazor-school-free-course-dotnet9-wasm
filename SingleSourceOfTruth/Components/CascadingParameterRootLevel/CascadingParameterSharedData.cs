using Microsoft.AspNetCore.Components;

namespace SingleSourceOfTruth.Components.CascadingParameterRootLevel;

public class CascadingParameterSharedData
{
    public int Value { get; set; }

    public CascadingValueSource<CascadingParameterSharedData> Source { get; set; }
}
