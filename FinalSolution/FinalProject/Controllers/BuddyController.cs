using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

public class BuddyController : Controller 
{

    [HttpGet]
    public IActionResult BuddyForm(string? pokemon, double? weight, string? allergy, string? food, string? nickname)
    {
        if(pokemon != null && weight != null && food != null && nickname != null)
        {
            List<string> summary = new List<string>();
            summary.Add(pokemon);
            string stringWeight = weight.ToString();
            summary.Add(stringWeight);
            if(pokemon == "Mimikyu")
            {
                if(weight > 4)
                {
                    summary.Add("Overweight");
                } else if(weight < 1)
                {
                    summary.Add("Underweight");
                } else 
                {
                    summary.Add("Regular");
                }
            }
            else if(pokemon == "Eevee")
            {
                if(weight > 20)
                {
                    summary.Add("Overweight");
                } else if(weight < 8)
                {
                    summary.Add("Underweight");
                }
                else
                {
                    summary.Add("Regular");
                }
            }
            else if(pokemon == "Gengar")
            {
                if(weight > 110)
                {
                    summary.Add("Overweight");
                } else if(weight < 70)
                {
                    summary.Add("Underweight");
                }
                else
                {
                    summary.Add("Regular");
                }
            }
            else if(pokemon == "Charizard")
            {
                if(weight > 230)
                {
                    summary.Add("Overweight");
                } else if(weight < 170)
                {
                    summary.Add("Underweight");
                }
                else
                {
                    summary.Add("Regular");
                }
            }
            else
            {
                if(weight > 550)
                {
                    summary.Add("Overweight");
                } else if(weight < 420)
                {
                    summary.Add("Underweight");
                }
                else
                {
                    summary.Add("Regular");
                }
            }
            summary.Add(allergy);
            summary.Add(food);
            summary.Add(nickname);

            return View("Summary", summary);
        }
    return View();
    }
}