namespace FinalProject.Models {
    public class Day {
        //C# properties
        public Meal Breakfast {get; set;}
        public Meal Lunch {get; set;}
        public Meal Dinner {get; set;}

        public Day()
        {
            Breakfast = new Meal();
            Lunch = new Meal();
            Dinner = new Meal();
        }
    }
}