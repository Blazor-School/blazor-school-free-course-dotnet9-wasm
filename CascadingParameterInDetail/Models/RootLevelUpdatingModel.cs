using Microsoft.AspNetCore.Components;

namespace CascadingParameterInDetail.Models;

public class RootLevelUpdatingModel
{
    public string Message { get; set; } = "";
    public CascadingValueSource<RootLevelUpdatingModel>? Source { get; set; }
}
