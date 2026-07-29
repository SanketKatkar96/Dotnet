namespace Catlog;
using System.Collections.Generic;
using Entities;

public class ProductService
{
    public static List<Product> GetAll()
    {
        List<Product>products=new List<Product>();
       products.Add(new Product{Id=22,Titel="Gerbera",price=89.90});
       products.Add(new Product{Id=22,Titel="Rose",price=90.09});
       products.Add(new Product{Id=22,Titel=" Tulip",price=46.99});
       products.Add(new Product{Id=22,Titel="Zendu",price=67.88});
       products.Add(new Product{Id=22,Titel="Jaswand",price=56.87});
       return products;    
    }
    public static string Insert()
    {
        Console.WriteLine("New product insterttion process");
        return "product insertd sucessfully";

    }
}