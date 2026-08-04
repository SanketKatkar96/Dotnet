namespace ADDHARCARD;

public class Addhar
{
    public string Name {get;set;}
    public long MobileNo{get; set;}
    public int DateofB{get; set;}
    public string Address{get;set;}

    public Addhar (string name,long mobileNo,int dateofB,string address)
    {
        Name = name;
        MobileNo = mobileNo;
        DateofB = dateofB;
        Address = address;
    }
    public void Display()
    {
        Console.WriteLine("Name:"+Name);
        Console.WriteLine("MobileNo:"+MobileNo);
        Console.WriteLine("DateofB:"+DateofB);
        Console.WriteLine("Address:"+Address);
    }

} 