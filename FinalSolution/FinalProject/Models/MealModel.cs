using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models {
    public class Meal {
        [Required(ErrorMessage = "Name the planned meal")]
        [StringLength(100, MinimumLength =2)]
        public string MealTitle {get; set;}
        public string? MealNotes {get; set;}
        [Required(ErrorMessage = "Please select how many people will be eating. No more than 1000 guest may attend a meal")]
        [Range(1, 1000)]
        public int? Guests {get; set;}

    }
}