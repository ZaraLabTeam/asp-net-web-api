namespace JokesApi.Services.Data
{
    using System.Linq;

    using JokesApi.Data.Models;
    using RequestModels;

    public interface IJokesService
    {
        IQueryable<Joke> GetRandomJokes(int count);

        Joke GetById(string id);

        Joke GetById(int id);

        IQueryable<Joke> GetRange(int start, int end);

        Joke Create(JokeCreateModel model, JokeCategory category);
    }
}
