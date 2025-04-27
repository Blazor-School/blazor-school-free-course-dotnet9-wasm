using Microsoft.AspNetCore.Components;

namespace CascadingParameterInDetail.Models;

public class RootLevelNotifyingModel
{
    public string Message { get; set; } = "";
    public CascadingValueSource<RootLevelNotifyingModel>? Source { get; set; }
}
