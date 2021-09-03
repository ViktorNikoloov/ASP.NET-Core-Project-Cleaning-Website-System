namespace CleaningWeb.Web.Areas.Administration.Controllers
{
    using CleaningWeb.Common;
    using CleaningWeb.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
