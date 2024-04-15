using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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
                return Results.NotFound("No animal in database");
            }
            return Results.Ok(Animal);
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
            animal.weight = updatedAnimal.weight;
            animal.Color = updatedAnimal.Color; 
            
            return Results.Ok(animal);
        });
        
        app.MapPost("/animals", (Animal newAnimal) =>
        {
            var newId = StaticData.animals.Max(a => a.Id) + 1;
            newAnimal.Id = newId; 
            StaticData.animals.Add(newAnimal);
            return Results.Created();
        });
        app.MapDelete("/animals/{id}", (int id) =>
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound("No animal with that ID.");
            }
            else
            {
                StaticData.animals.Remove(animal);
            }

            return Results.Ok();
        });

        app.MapGet("/visits/{id}", (int id) =>
        {
            var visitsList = Visits.VisitsList.FindAll(a=>a.Animal.Id ==id);
            return Results.Ok(visitsList);
        });
        
        app.MapPut("/visits", (Visits newVisit) =>
        {
            Visits.VisitsList.Add(newVisit);
            return Results.Ok(newVisit);
        });
    }
}
