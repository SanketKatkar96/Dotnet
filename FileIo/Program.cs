 namespace FileIO;
 public class Program
{
    public static void Main(string []args)
    {
        string filename="employee.json";
        List<Employee> employees =  new List<Employee>()
        {

            new Employee(),
            new Employee(1,"Omkar Karkar",230000.90,"Anandnagar"),
            new Employee(27,"pranav Dhalale",22000.34,"junner"),
            new Employee(39,"sumit Bhor",24000.34,"mannchar"),
            new Employee(40,"Sachin Kharat",45000.45,"Sambhajinagar")
        
        };


        FileManager fileManager =new FileManager();
        fileManager.Serialize(employees,filename);

        List<Employee> emps = fileManager.Deserialize(filename);
        foreach(Employee emp in emps)
        {
            Console.WriteLine($"Id={emp.Id}Name={emp.Name} Salary={emp.Salary} Address={emp.address}");
        }
    }
}