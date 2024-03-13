using System.Diagnostics;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers;

public class MenuController : Controller 
{
    [HttpGet]
    public IActionResult MenuPlanner()
    {
        return View();
    }

    [HttpGet] //, int day, int meal
    public IActionResult AddToPlanner()
    {
        Debug.WriteLine("Inside Menu Controller");
        return View("AddToPlanner");
    }
//Solving how to bind the variables correctly
    [HttpPost]
    public IActionResult AddToPlanner(HelperMeal meal)
    {
        Day day = new Day();
        if(meal.MealCode == 0)
        {
            day.Breakfast = meal.NewMeal;
            switch(meal.DayCode)
            {
                case 0:
                    Repository.Week.Monday.Breakfast = day.Breakfast;
                    break;
                case 1:
                    Repository.Week.Tuesday.Breakfast = day.Breakfast;
                    break;
                case 2:
                    Repository.Week.Wednesday.Breakfast = day.Breakfast;
                    break;
                case 3:
                    Repository.Week.Thursday.Breakfast = day.Breakfast;
                    break;
                case 4:
                    Repository.Week.Friday.Breakfast = day.Breakfast;
                    break;
                case 5:
                    Repository.Week.Saturday.Breakfast = day.Breakfast;
                    break;
                case 6:
                    Repository.Week.Sunday.Breakfast = day.Breakfast;
                    break;
            }
        }
        else if(meal.MealCode == 1)
        {
            day.Lunch = meal.NewMeal;
            switch(meal.DayCode)
            {
                case 0:
                    Repository.Week.Monday.Lunch = day.Lunch;
                    break;
                case 1:
                    Repository.Week.Tuesday.Lunch = day.Lunch;
                    break;
                case 2:
                    Repository.Week.Wednesday.Lunch = day.Lunch;
                    break;
                case 3:
                    Repository.Week.Thursday.Lunch = day.Lunch;
                    break;
                case 4:
                    Repository.Week.Friday.Lunch = day.Lunch;
                    break;
                case 5:
                    Repository.Week.Saturday.Lunch = day.Lunch;
                    break;
                case 6:
                    Repository.Week.Sunday.Lunch= day.Lunch;
                    break;
            }
        }
        else if(meal.MealCode == 2)
        {
            day.Dinner = meal.NewMeal;
            switch(meal.DayCode)
            {
                case 0:
                    Repository.Week.Monday.Dinner = day.Dinner;
                    break;
                case 1:
                    Repository.Week.Tuesday.Dinner = day.Dinner;
                    break;
                case 2:
                    Repository.Week.Wednesday.Dinner = day.Dinner;
                    break;
                case 3:
                    Repository.Week.Thursday.Dinner = day.Dinner;
                    break;
                case 4:
                    Repository.Week.Friday.Dinner = day.Dinner;
                    break;
                case 5:
                    Repository.Week.Saturday.Dinner = day.Dinner;
                    break;
                case 6:
                    Repository.Week.Sunday.Dinner = day.Dinner;
                    break;
            }
        }
        

        return View("MenuPlanner", Repository.Week);
    }

}