using System.Drawing;

namespace Tutorial4.DataBase;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Rex", PetCategory.Dog, 30.0, KnownColor.SaddleBrown),
        new Animal(2, "Whiskers", PetCategory.Cat, 5.0, KnownColor.Silver),
        new Animal(3, "Tweety", PetCategory.Bird, 0.5, KnownColor.Yellow),
        new Animal(4, "Goldie", PetCategory.Fish, 0.1, KnownColor.Gold),
        new Animal(5, "Bunny", PetCategory.Rabbit, 4.0, KnownColor.Wheat),
        new Animal(6, "Shadow", PetCategory.Cat, 4.5, KnownColor.Gray),
        new Animal(7, "Fido", PetCategory.Dog, 20.0, KnownColor.SteelBlue),
        new Animal(8, "Blub", PetCategory.Fish, 0.2, KnownColor.Teal),
        new Animal(9, "Flappy", PetCategory.Bird, 0.3, KnownColor.MediumOrchid),
        new Animal(10, "Snuggles", PetCategory.Rabbit, 3.5, KnownColor.PeachPuff),
        new Animal(11, "Paws", PetCategory.Dog, 22.5, KnownColor.OliveDrab),
        new Animal(12, "Splash", PetCategory.Fish, 0.4, KnownColor.SteelBlue)
    };
}