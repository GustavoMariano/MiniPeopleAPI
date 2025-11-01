using MinimalApi.Models;
using MinimalApi.Services;

namespace MinimalApi.Endpoints;

public static class PeopleEndpoints
{
    public static void MapPeopleEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/people");

        group.MapGet("/", (PersonService service) =>
        {
            return Results.Ok(service.GetAll());
        });

        group.MapPost("/", (PersonService service, Person person) =>
        {
            service.Add(person);
            return Results.Created($"/people/{person.Id}", person);
        });

        group.MapGet("/{id:int}", (PersonService service, int id) =>
        {
            var person = service.GetById(id);
            return person is not null ? Results.Ok(person) : Results.NotFound();
        });
    }
}
