using System.Drawing;

namespace Tutorial4;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double weight { get; set; }
    public string Color { get; set; }

    public Animal(int id, string name, string category, double weight, string color)
    {
        Id = id;
        Name = name;
        Category = category;
        this.weight = weight;
        Color = color;
    }
}