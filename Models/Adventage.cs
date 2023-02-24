namespace BonFromage.Models;

public class Adventage
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Description{get;set;}

    public Adventage(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public Adventage(){}
}