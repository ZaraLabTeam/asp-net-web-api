namespace JokesApi.Services.Data
{
    using System.Linq;

    using JokesApi.Data.Models;

    public interface ICategoriesService
    {
        IQueryable<JokeCategory> GetAll();

        JokeCategory EnsureCategory(string name);
    }
}
