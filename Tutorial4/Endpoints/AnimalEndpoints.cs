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
            return Results.Ok(id);
        });

        app.MapPost("animals", () =>
        {
            return Results.Created();
        });

    }
}