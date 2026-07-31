using System.Reflection;

public  class Employee
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Salary {get;set;}
    public string address {get;set;}

public Employee(int id,string name,double salary,string address)
    {
        this.Id=id;
        this.Name=name;
        this.Salary=salary;
        this.address=address;
    }
    public Employee()
    {
        this.Id=1;
        this.Name="Sanket Katkar";
        this.Salary=30000.33;
        this.address="Akluj";  
    }

}