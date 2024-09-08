using MiniamalAPI_Movie.Entities;

var builder = WebApplication.CreateBuilder(args);
var lastName = builder.Configuration.GetValue<string>("lastName");
var app = builder.Build();

app.MapGet("/", () => lastName);

app.MapGet("/genres", () =>
{
    var genres = new List<Genre>
    {
        new Genre { Id = 1, Name = "Action" },
        new Genre { Id = 2, Name = "Comedy" },
        new Genre { Id = 3, Name = "Drama" }
    };
    return genres;
});

app.Run();
