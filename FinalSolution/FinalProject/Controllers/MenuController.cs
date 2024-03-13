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

    [HttpPost]
    public IActionResult MenuPlanner(int delete)
    {
        if(delete == 99)
        {
            Repository.Week.Monday = new Day();
            Repository.Week.Tuesday = new Day();
            Repository.Week.Wednesday = new Day();
            Repository.Week.Thursday = new Day();
            Repository.Week.Friday = new Day();
            Repository.Week.Saturday = new Day();
            Repository.Week.Sunday = new Day();
        }
        else if(delete >= 20)
        {
            switch(delete)
            {
                case 20:
                    Repository.Week.Monday.Dinner = new Meal();
                    break;
                case 21:
                    Repository.Week.Tuesday.Dinner = new Meal();
                    break;
                case 22:
                    Repository.Week.Wednesday.Dinner = new Meal();
                    break;
                case 23:
                    Repository.Week.Thursday.Dinner = new Meal();
                    break;
                case 24:
                    Repository.Week.Friday.Dinner = new Meal();
                    break;
                case 25:
                    Repository.Week.Saturday.Dinner = new Meal();
                    break;
                case 26:
                    Repository.Week.Sunday.Dinner = new Meal();
                    break;
            }
        }
        else if(delete >= 10)
        {
            switch(delete)
            {
                case 10:
                    Repository.Week.Monday.Lunch = new Meal();
                    break;
                case 11:
                    Repository.Week.Tuesday.Lunch = new Meal();
                    break;
                case 12:
                    Repository.Week.Wednesday.Lunch = new Meal();
                    break;
                case 13:
                    Repository.Week.Thursday.Lunch = new Meal();
                    break;
                case 14:
                    Repository.Week.Friday.Lunch = new Meal();
                    break;
                case 15:
                    Repository.Week.Saturday.Lunch = new Meal();
                    break;
                case 16:
                    Repository.Week.Sunday.Lunch = new Meal();
                    break;
            }
        }
        else
        {
            switch(delete)
            {
                case 00:
                    Repository.Week.Monday.Breakfast = new Meal();
                    break;
                case 01:
                    Repository.Week.Tuesday.Breakfast = new Meal();
                    break;
                case 02:
                    Repository.Week.Wednesday.Breakfast = new Meal();
                    break;
                case 03:
                    Repository.Week.Thursday.Breakfast = new Meal();
                    break;
                case 04:
                    Repository.Week.Friday.Breakfast = new Meal();
                    break;
                case 05:
                    Repository.Week.Saturday.Breakfast = new Meal();
                    break;
                case 06:
                    Repository.Week.Sunday.Breakfast = new Meal();
                    break;
            }
        }
        return View(Repository.Week);
    }

    [HttpGet] 
    public IActionResult AddToPlanner()
    {
        return View();
    }


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