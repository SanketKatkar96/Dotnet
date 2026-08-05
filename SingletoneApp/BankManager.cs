namespace HR;
public sealed class Bankmanager
{
    private static Bankmanager? _instance = null;
    private Bankmanager()
    {
        
    }
    public static Bankmanager Instance
    {
        get
        {
            if (_instance ==null)
            {
                _instance =new Bankmanager();
            }
            return _instance;
        }
    }
    public void ApproveLoan(decimal amount)
    {
        Console.WriteLine($"Bank Manager approved a loan of {amount}.");
    }
}