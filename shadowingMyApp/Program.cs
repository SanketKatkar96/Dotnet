using System;
 

public class IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

 public class Dog :  IAnimal
{
    // Shadowing the Sound() method of Animal class
    public new void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Program
{
    static void Main()
    {
        IAnimal a = new IAnimal();
        a.Sound();   // Calls Animal method

        Dog d = new Dog();
        d.Sound();   // Calls Dog method (shadowed method)

        IAnimal ad = new ();
        ad.Sound();  // Calls Animal method because of shadowing
    }
}