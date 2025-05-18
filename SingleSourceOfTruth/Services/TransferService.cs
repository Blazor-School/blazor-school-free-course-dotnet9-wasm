using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace SingleSourceOfTruth.Services;

public class TransferService
{
    public string Message { get; set; } = "";
    private List<IComponent> _components = [];

    public void NotifyChanged()
    {
        foreach (var component in _components)
        {
            var stateHasChangedMethod = component.GetType().GetMethod("StateHasChanged", BindingFlags.Instance | BindingFlags.NonPublic);
            stateHasChangedMethod?.Invoke(component, null);
        }
    }

    public void SubcribeNotification(IComponent component)
    {
        _components.Add(component);
    }

    public void UnsubcribeNotification(IComponent component)
    {
        _components.Remove(component);
    }
}
