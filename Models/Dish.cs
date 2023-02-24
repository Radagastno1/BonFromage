namespace BonFromage.Models;

public class Dish
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Description{get;set;}
    public float Price{get;set;}

    public Dish(string name, string description, float price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
    public Dish(){}
}