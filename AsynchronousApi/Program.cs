using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> GetDataAsync()
    {
        await Task.Delay(2000);    //wating for 2 second .
        return " Data is Loaded";

    }
    static async Task Main()
    {
        try
        {
            Console.WriteLine("Hello Sanket...");
            string data =await GetDataAsync();
            Console.WriteLine(data);

        }
        catch(Exception ex)  //
        {
            Console.WriteLine(ex.Message);
        }
        
    }

}
