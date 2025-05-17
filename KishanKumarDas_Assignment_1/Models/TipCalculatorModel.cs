using System.ComponentModel.DataAnnotations;

namespace KishanKumarDas_Assignment_1.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Cost of meal is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0")]
        public decimal? MealCost { get; set; }

        public decimal? TipCost15 => MealCost.HasValue ? MealCost.Value * 0.15m : 0;
        public decimal? TipCost20 => MealCost.HasValue ? MealCost.Value * 0.20m : 0;
        public decimal? TipCost25 => MealCost.HasValue ? MealCost.Value * 0.25m : 0;
    }
}
