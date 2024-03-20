using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

    }
}
public class Product
{
    private int Price { get; }
    private string Name { get; }
    private int Kg { get; }
    public Product(int Price2, string Name2, int Kg2)
    {
        Price = Price2;
        Name = Name2;
        Kg = Kg2;
    }
}

public class BasketManager
{
    List<Product> products = new List<Product>();
    public static readonly BasketManager basketManager;
    static BasketManager()
    {
        basketManager = new BasketManager();
    }
    private BasketManager()
    {

    }
    public void AddProduct(Product product)
    {
        Console.WriteLine("продукт добавлен");
    }
    public void RemoveProduct()
    {
        Console.WriteLine("продукт удален");
    }
    public void SendOrder()
    {
        Console.WriteLine("продукт заказан");
    }
}
public class AddProduct : ICommand
{
    public void Run()
    {
        int.TryParse(Console.ReadLine(), out int price);
        string name = Console.ReadLine();
        int.TryParse(Console.ReadLine(), out int kg);
        Product product = new Product(price,name, kg);
        BasketManager.basketManager.AddProduct(product);
    }
}
public interface ICommand
{
    public void Run();
}