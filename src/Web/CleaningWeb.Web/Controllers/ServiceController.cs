namespace CleaningWeb.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ServiceController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult OfficeCleaning()
        {
            return this.View();
        }

        public IActionResult PoolCleaning()
        {
            return this.View();
        }

        public IActionResult CarpetCleaning()
        {
            return this.View();
        }

        public IActionResult KitchenCleaning()
        {
            return this.View();
        }

        public IActionResult GardenCleaning()
        {
            return this.View();
        }

        public IActionResult WindowCleaning()
        {
            return this.View();
        }
    }
}
