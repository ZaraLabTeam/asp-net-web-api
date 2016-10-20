﻿namespace JokesApi.Web.Controllers
{
    using System.Web.Mvc;

    using JokesApi.Services.Data;
    using JokesApi.Web.Infrastructure.Mapping;
    using JokesApi.Web.ViewModels.Home;

    public class JokesController : BaseController
    {
        private readonly IJokesService jokes;

        public JokesController(
            IJokesService jokes)
        {
            this.jokes = jokes;
        }

        public ActionResult ById(string id)
        {
            var joke = this.jokes.GetById(id);
            var viewModel = this.Mapper.Map<JokeViewModel>(joke);
            return this.View(viewModel);
        }
    }
}
