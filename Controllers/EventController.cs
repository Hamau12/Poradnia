using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.Models.DTOs;
using System.Data;
using System.Threading.Tasks;

namespace SRP.Controllers
{
    //public class EventController : BaseController
    //{
    //    public EventController()
    //    {

    //    }
    //    //[HttpPost]
    //    [Authorize(Roles = "Admin, SuperAdmin, Doctor")]
    //    public IActionResult CreateEvent()
    //    {
    //        return View("Create");
    //    }
    //    [HttpPost]
    //    [Authorize(Roles = "Admin, SuperAdmin, Doctor")]
    //    public async Task<IActionResult> CreateEvent(EventDto eventDto)
    //    {
    //        if (eventDto == null)
    //        {
    //            return View("Error");
    //        }

    //        return View("Create");
    //    }
    //}
}
