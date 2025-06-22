namespace SingleSourceOfTruth.Components.TransferService;

public class BlazorSchoolTransferService
{
    public string Message { get; set; } = "";
    public event EventHandler MessageChanged = (sender, args) => { };

    public void NotifyChanged()
    {
        MessageChanged.Invoke(this, EventArgs.Empty);
    }
}
