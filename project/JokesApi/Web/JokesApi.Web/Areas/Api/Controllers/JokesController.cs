namespace JokesApi.Web.Areas.Api.Controllers
{
    using System;
    using System.Web.Http;
    using Services.Data;
    using ViewModels.Home;

    public class JokesController : BaseController
    {
        private readonly IJokesService jokes;

        public JokesController(IJokesService jokes)
        {
            this.jokes = jokes;
        }

        public IHttpActionResult GetList(int start, int end)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        public IHttpActionResult Get(string id)
        {
            var joke = this.jokes.GetById(id);
            var viewModel = this.Mapper.Map<JokeViewModel>(joke);

            return this.Ok(viewModel);
        }
    }
}
