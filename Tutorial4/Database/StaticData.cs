using System.Drawing;

namespace Tutorial4.DataBase;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Rex", "Dog", 30.0, "SaddleBrown"),
        new Animal(2, "Whiskers", "Cat", 5.0, "Silver"),
        new Animal(3, "Tweety", "Bird", 0.5, "Yellow"),
        new Animal(4, "Goldie", "Fish", 0.1, "Gold"),
        new Animal(5, "Bunny", "Rabbit", 4.0, "Wheat"),
        new Animal(6, "Shadow", "Cat", 4.5, "Gray"),
        new Animal(7, "Fido", "Dog", 20.0, "SteelBlue"),
        new Animal(8, "Blub", "Fish", 0.2, "Teal"),
        new Animal(9, "Flappy", "Bird", 0.3, "MediumOrchid"),
        new Animal(10, "Snuggles", "Rabbit", 3.5, "PeachPuff"),
        new Animal(11, "Paws", "Dog", 22.5, "OliveDrab"),
        new Animal(12, "Splash", "Fish", 0.4, "SteelBlue")
    };
    public static void DeleteAnimal(int id)
    {
        foreach (var animal in animals)
        {
            if (animal.Id == id)
            {
                animals.Remove(animal);
                break;
            }
        }
        // for (int i = 0; i < animals.Capacity; i++)
        // {
        //     if (animals[i].Id == id)
        //     {
        //         animals.Remove(animals[i]);
        //         break;
        //     }
        // }

    }
}