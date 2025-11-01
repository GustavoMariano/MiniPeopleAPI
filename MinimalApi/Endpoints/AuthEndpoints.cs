namespace MinimalApi.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/login", (LoginRequest req) =>
        {
            if (req.Username == "admin" && req.Password == "123")
                return Results.Ok(new { token = "fake-jwt-token" });

            return Results.Unauthorized();
        });
    }
}

public record LoginRequest(string Username, string Password);
