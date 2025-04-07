namespace ComponentCommunication.Components.SingleSourceOfTruth;

// This class is registered as a service in the Program.cs file.
public class BlazorSchoolTransferService
{
    private string _helloMessage;

    public string HelloMessage
    {
        get => _helloMessage; 
        
        set
        {
            _helloMessage = value;
            HelloMessageChanged?.Invoke(this, value);
        }
    }

    public event EventHandler<string> HelloMessageChanged = (sender, value) => { };
}
