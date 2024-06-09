using MongoDB.Driver;


var builder = WebApplication.CreateBuilder(args);

var movieDatabaseConfigSection = builder.Configuration.GetSection("DatabaseSettings");
builder.Services.Configure<DatabaseSettings>(movieDatabaseConfigSection);
builder.Services.AddSingleton<MovieService>();

var app = builder.Build();

app.MapGet("/", () => "Minimal API nach Arbeitsauftrag 2");

// docker run --name mongodb -d -p 27017:27017 -v data:/data/db -e MONGO_INITDB_ROOT_USERNAME=gbs -e MONGO_INITDB_ROOT_PASSWORD=geheim mongo
app.MapGet("/check", (MovieService movieService) =>
{
    return movieService.Check();
});

//insert Movie
//teil3
app.MapPost("/api/movies", () =>
{
    throw new NotImplementedException();
});

app.MapGet("api/movies", ()=>
{
    throw new NotImplementedException();
});

app.MapGet("api/movies/{id}", (string id) =>
{
    if(id == "1")
    {
        var myMovie = new Movie()
        {
            Id = "1",
            Title = "Asterix und Obelix",
        };
        return Result.Ok(myMovie);
    } else
    {
        return Results.NotFound();
    }
});

app.MapPut("api/movies/{id}", (string id, Movie movie) =>
{
    throw new NotImplementedException();
});

app.MapDelete("api/movies/{id}", (string id) =>
{
    throw new NotImplementedException();
});


app.Run();
