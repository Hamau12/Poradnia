

using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SRP.Controllers;
using Controller = System.Web.Mvc.Controller;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;

namespace Poradnia.Controllers
{
    public class WorkScheduleController : BaseController
    {
        [Authorize(Users = "Doctor")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
