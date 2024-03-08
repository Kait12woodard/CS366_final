using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

public class BuddyController : Controller 
{
    [HttpGet]
    public IActionResult BuddyForm()
    {
        return View();
    }
}