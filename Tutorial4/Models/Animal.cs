using System.Drawing;

namespace Tutorial4;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PetCategory Category { get; set; }
    public double weight { get; set; }
    public KnownColor Color { get; set; }

    public Animal(int id, string name, PetCategory category, double weight, KnownColor color)
    {
        Id = id;
        Name = name;
        Category = category;
        this.weight = weight;
        Color = color;
    }
}