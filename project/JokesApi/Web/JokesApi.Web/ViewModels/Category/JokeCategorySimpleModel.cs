namespace JokesApi.Web.ViewModels.Category
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class JokeCategorySimpleModel : IMapFrom<JokeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
