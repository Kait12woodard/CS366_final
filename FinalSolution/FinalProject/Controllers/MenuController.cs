using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

public class MenuController : Controller 
{
    [HttpGet]
    public IActionResult MenuPlanner()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddToPlanner()
    {
        return View();
    }

}