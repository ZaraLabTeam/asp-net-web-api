namespace JokesApi.Web.Controllers.Api
{
    using System.Web.Http;
    using AutoMapper;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;

    public abstract class BaseApiController : ApiController
    {
        protected string UserId => this.User.Identity.GetUserId();

        protected IMapper Mapper => AutoMapperConfig.Configuration.CreateMapper();
    }
}
