using Tutorial4.DataBase;

namespace Tutorial4;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            //200 - OK
            //201 - Created
            //400 - Bad request
            //401 - Unauthorized
            //403 - Forbiden
            //404 - Not Found

            var animals = StaticData.animals;
            return Results.Ok(animals);

        });
        app.MapGet("/animals/{id}", (int id) =>
        {
            Animal Animal = null;
            foreach (var TmpAnimal in StaticData.animals)
            {
                if (TmpAnimal.Id.Equals(id))
                {
                    Animal = TmpAnimal;
                    break;
                }
            }
            if (Animal == null)
            {
                return Results.Problem("No animal in database");
            }
            return Results.Ok(Animal);
        });

        app.MapPost("animals", () =>
        {
            return Results.Created();
        });
        app.MapPut("/animals/{id}", (int id, Animal updatedAnimal) =>
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound("No animal with that ID.");
            }

            animal.Name = updatedAnimal.Name;
            animal.Category = updatedAnimal.Category; 
            animal.weight = updatedAnimal.weight > 0 ? updatedAnimal.weight : animal.weight;  
            animal.Color = updatedAnimal.Color; 
            
            return Results.Ok(animal);
        });
    }
    }
