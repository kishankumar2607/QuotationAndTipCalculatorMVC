using System.ComponentModel.DataAnnotations;

namespace KishanKumarDas_Assignment_1.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage ="Please enter a sale price")]
        [Range(0, double.MaxValue, ErrorMessage ="Subtotal must be greater than 0.")]
        public decimal? SubTotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount price")]
        [Range(0,100, ErrorMessage ="Discount percentage must be between 0 to 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount =>
            SubTotal.HasValue && DiscountPercent.HasValue
                ? SubTotal.Value * DiscountPercent.Value / 100
                : 0;

        public decimal Total =>
            SubTotal.HasValue
                ? SubTotal.Value - DiscountAmount
                : 0;
    }
}
