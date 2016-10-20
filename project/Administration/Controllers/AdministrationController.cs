namespace JokesApi.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using JokesApi.Common;
    using JokesApi.Web.Controllers;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class AdministrationController : BaseController
    {
    }
}
