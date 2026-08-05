using HR;
namespace HR;
public class Program
{
    public static void Main()
    {
        Bankmanager M1= Bankmanager .Instance;
        Bankmanager M2= Bankmanager.Instance;
        
        M1.ApproveLoan(500000);

        Console.WriteLine(Object.ReferenceEquals(M1,M2));

    }
}