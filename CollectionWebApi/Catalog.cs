using System.Collections.Generic;
using HR;
public class Catalog
{
    private List<Product> products= new List<Product>();

    public Product this[int index]
    {
        get
        {
            if (index >=0 && index < products.Count)
                return products[index];

            else
            throw new IndexOutOfRangeException("Invalid product index !");
        }
        set
        {
            if (index >=0 && index < products.Count)
            
                products[index] = value;
            else
                  throw new IndexOutOfRangeException("Invalid Product index!");

            
        }
        


    }
    public void AddProduct(Product p)
    {
        products.Add(p);
    }
    public int Count
    {
        get {return products.Count;}
    }
}