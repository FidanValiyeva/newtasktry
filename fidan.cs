using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Notebook notebook = new notebook (name"asus",description "game comp",count"30",IsStock"yes",Price "1500",RAM:"64",Storage"512");
        
        Notebook.ShowfullInfo();
        Notebook.GetfullInfo();
        Notebook.Sale();
    }
}
public class Product 
{
    public string Name;
    public string Description;
    public int Count;
    public bool IsStock;
    public double Price;
      
    public  Product (string name ,string description, int count,bool isStock,double Price)
    {
        this.name = name;
        this.description = description;
        this.count = count;
        this.isStock = isStock;
        this.price = price;
            
    }
        
    public void GetFullInfo()
    {
        Console.WriteLine($"Product: {name},{description}","{count}","{isStock}","price");
    }
}

public class Notebook:Product
{
    public byte RAM;
    public int Storage;

    public class Notebook(string name, string description, int count, bool isStock, double price, byte RAM, int storage):Base(name,description,count,isStock,price)
    {
        this.RAM = RAM;
        this.storage = storage;
    }
    
    public void Sale()
    {
        if (count > 0)
        {
            Console.WriteLine("mehsul var!");
        }
        else 
        {
            Console.WriteLine("mehsul yoxdur!");
        }
    }
    
    public void ShowfullInfo()
    {
        Console.WriteLine($"Notebook: {ram},{storage}");
    }
    public void GetfullData()
    {
        Console.WriteLine($"Product: {name},{description}","{count}","{isStock}","{price}","{ram}","{storage}");
    }


}