using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

public class BuddyController : Controller 
{
    //This is my big Get Method. It verifies the information given, based on your answers
    //it will determine if your health status of your pokemon and add a summary about it into
    //the string, uppercase the allergies


    [HttpGet]
    public IActionResult BuddyForm(string? pokemon, double? weight, string? allergy, string? food, string? nickname,string submit)
    {
        if(submit != null)
        {
            ViewData["ErrorMessage"]= null;
            if(pokemon == null)
            {
                ViewData["ErrorMessage"]= "Please select a Pokemon Buddy";
                return View();
            }
            else if(weight == null || weight > 1000 || weight < 1)
            {
                ViewData["ErrorMessage"]= "Please enter a valid Weight between 1 and 1000";
                return View();
            }
            else if(food == null || food.Length < 2 || food.Length > 100)
            {
                ViewData["ErrorMessage"]= "Please enter a valid Favorite Food.(Between 2 and 100 characters long)";
                return View();
            }
            else if(nickname == null || nickname.Length < 2 || nickname.Length > 100)
            {
                ViewData["ErrorMessage"]= "Please enter a valid Nickname.(Between 2 and 100 characters long)";
                return View();
            }
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
                summary.Add("Healthy weight for a Mimikyu is between 1-4 pounds");
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
                summary.Add("Healthy weight for a Eevee is between 8-20 pounds");
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
                summary.Add("Healthy weight for a Gengar is between 70-100 pounds");
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
                summary.Add("Healthy weight for a Charizard is between 170-230 pounds");
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
                summary.Add("Healthy weight for a Lapras is between 420-550 pounds");
            }
            allergy = allergy.ToUpper();
            summary.Add(allergy);
            summary.Add(food);
            summary.Add(nickname);

            return View("Summary", summary);
        }

    return View("BuddyForm");
    }
}