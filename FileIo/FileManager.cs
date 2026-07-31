using System.Text.Json;
namespace FileIO;
public class FileManager
{
    public void Serialize(List<Employee>emp,string filename)
    {
        var option =new JsonSerializerOptions{IncludeFields =true};
        var JsonString=JsonSerializer.Serialize(emp,option);
        File.WriteAllText(filename, JsonString);

    }
    public List<Employee>Deserialize(string filename)
    {
        var JsonString=File.ReadAllText(filename);
        List<Employee>employees = JsonSerializer.Deserialize<List<Employee>>(JsonString);
        return employees;
         
    }
}