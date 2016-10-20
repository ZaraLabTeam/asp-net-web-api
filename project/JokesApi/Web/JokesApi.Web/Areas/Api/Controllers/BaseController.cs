namespace JokesApi.Web.Areas.Api.Controllers
{
    using System.Web.Http;
    using AutoMapper;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;

    public abstract class BaseController : ApiController
    {
        protected string UserId => this.User.Identity.GetUserId();

        protected IMapper Mapper => AutoMapperConfig.Configuration.CreateMapper();
    }
}
