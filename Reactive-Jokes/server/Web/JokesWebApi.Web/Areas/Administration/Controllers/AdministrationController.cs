namespace JokesWebApi.Web.Areas.Administration.Controllers
{
    using JokesWebApi.Common;
    using JokesWebApi.Web.Controllers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
