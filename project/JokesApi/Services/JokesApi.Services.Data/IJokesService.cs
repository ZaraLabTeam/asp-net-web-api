namespace JokesApi.Services.Data
{
    using System.Linq;

    using JokesApi.Data.Models;

    public interface IJokesService
    {
        IQueryable<Joke> GetRandomJokes(int count);

        Joke GetById(string id);
    }
}
