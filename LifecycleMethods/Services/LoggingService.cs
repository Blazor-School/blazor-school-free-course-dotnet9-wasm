using System.Collections.ObjectModel;

namespace LifecycleMethods.Services;

public class LoggingService
{
    public ObservableCollection<string> Logs { get; set; } = [];
}
