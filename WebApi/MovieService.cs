using Microsoft.Extensions.Options;
using MongoDB.Driver;

public class MovieService
{
    public MovieService(IOptions<DatabaseSettings> options)
    {

    }

    public string Check()
    {
        app.MapGet("/check", (Microsoft.Extensions.Options.IOptions<DatabaseSettings> options) =>
        {
            try
            {
                var mongoDbConnectionString = options.Value.ConnectionString;
                var mongoClient = new MongoClient(mongoDbConnectionString);
                var databaseNames = mongoClient.ListDatabaseNames().ToList();

                return "Zugriff auf MongoDB ok. Vorhandene DBs: " + string.Join(",", databaseNames);
            }
            catch (System.Exception e)
            {
                return "Zugriff auf MongoDB funktioniert nicht: " + e.Message;
            }
        });
    }

    public void Create(Movie movie)
    {
        throw new NotImplementedException;
    }

    public IEnumerable<Movie> Get()
    {
        throw new NotImplementedException;
    }

    public Movie Get(string id)
    {
        throw new NotImplementedException;
    }

    public void Update(string id, Movie movie)
    {
        throw new NotImplementedException;
    }

    public void Remove(string id)
    {
        throw new NotImplementedException;
    }
}