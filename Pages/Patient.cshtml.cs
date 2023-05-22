using System;
using System.Reflection.Metadata;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using SRP.interfaces;

namespace Poradnia.Pages
{
    public class PatientModel : PageModel
    {
        public string Parametr { get; private set; }
        public IActionResult OnGet()
        {

            if (TempData.ContainsKey("Parametr"))
            {
                Parametr = TempData["Parametr"].ToString();
            }
            ViewData["Parametr"] = Parametr;
            return Page();
        }
    }
}
