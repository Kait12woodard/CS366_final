using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models {
    //C# properties
    public class HelperMeal {
        public int DayCode {get; set;}
        public int MealCode {get; set;}
        public Meal NewMeal {get; set;}
    }
}