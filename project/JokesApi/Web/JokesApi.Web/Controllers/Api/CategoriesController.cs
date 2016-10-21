namespace JokesApi.Web.Controllers.Api
{
    using System.Linq;
    using System.Web.Http;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Category;

    [RoutePrefix("api/categories")]
    public class CategoriesController : BaseApiController
    {
        private readonly ICategoriesService categories;

        public CategoriesController(ICategoriesService categories)
        {
            this.categories = categories;
        }

        [Route("{name}")]
        public IHttpActionResult Get(string name)
        {
            var result = this.categories.Find(name);

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(this.Mapper.Map<CategoryContentModel>(result));
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            var all = this.categories.GetAll()
                .To<JokeCategorySimpleModel>()
                .ToList();

            return this.Ok(all);
        }
    }
}
