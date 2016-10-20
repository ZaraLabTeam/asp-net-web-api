namespace JokesApi.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Joke;

    public class IndexViewModel
    {
        public IEnumerable<JokeViewModel> Jokes { get; set; }

        public IEnumerable<JokeCategoryViewModel> Categories { get; set; }
    }
}
