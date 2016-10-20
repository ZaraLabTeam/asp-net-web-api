namespace JokesApi.Web.ViewModels.Home
{
    using JokesApi.Data.Models;
    using JokesApi.Web.Infrastructure.Mapping;

    public class JokeCategoryViewModel : IMapFrom<JokeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
