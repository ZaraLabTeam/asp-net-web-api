namespace JokesApi.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Category;
    using Joke;

    public class IndexViewModel
    {
        public IEnumerable<JokeViewModel> Jokes { get; set; }

        public IEnumerable<JokeCategorySimpleModel> Categories { get; set; }
    }
}
