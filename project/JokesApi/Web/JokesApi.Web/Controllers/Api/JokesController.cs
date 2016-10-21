namespace JokesApi.Web.Controllers.Api
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using Infrastructure.Mapping;
    using Services.Data;
    using Services.RequestModels;
    using ViewModels.Joke;

    public class JokesController : BaseApiController
    {
        private readonly IJokesService jokes;
        private readonly ICategoriesService categories;

        public JokesController(IJokesService jokes, ICategoriesService categories)
        {
            this.jokes = jokes;
            this.categories = categories;
        }

        public IHttpActionResult Get(int start, int end)
        {
            var jokes = this.jokes.GetRange(start, end)
                .To<JokeViewModel>()
                .ToList();

            return this.Ok(jokes);
        }

        public IHttpActionResult Get(int id)
        {
            var joke = this.jokes.GetById(id);
            if (joke == null)
            {
                return this.NotFound();
            }

            var viewModel = this.Mapper.Map<JokeViewModel>(joke);
            return this.Ok(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Create(JokeCreateModel model)
        {
            if (this.ModelState.IsValid == false)
            {
                return this.BadRequest(this.ModelState);
            }

            return this.TryCreateJoke(model);
        }

        [HttpGet]
        [Route("api/jokes/random/{count:int:min(1)}")]
        public IHttpActionResult Random(int count)
        {
            var jokes = this.jokes.GetRandomJokes(count)
                .To<JokeViewModel>()
                .ToList();

            return this.Ok(jokes);
        }

        private IHttpActionResult TryCreateJoke(JokeCreateModel model)
        {
            model.CreatedById = this.UserId;
            var category = this.categories.Find(model.Category);
            var joke = this.jokes.Create(model, category);
            var locationHeader = new Uri(this.Url.Link("JokesApi", new { id = joke.Id, controller = "Jokes" }));

            return this.Created(locationHeader, this.Mapper.Map<JokeViewModel>(joke));
        }
    }
}
