using KishanKumarDas_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KishanKumarDas_Assignment_1.Controllers
{
    public class PriceQuotationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel pcModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SubTotal = pcModel.SubTotal;
                ViewBag.DiscountPercent = pcModel.DiscountPercent;
                ViewBag.DiscountAmount = pcModel.DiscountAmount.ToString("0.00");
                ViewBag.Total = pcModel.Total.ToString("0.00");
            }
            else
            {
                ViewBag.SubTotal = pcModel.SubTotal;
                ViewBag.DiscountPercent = pcModel.DiscountPercent;
                ViewBag.DiscountAmount = "0.00";
                ViewBag.Total = "0.00";
            }

            return View();
        }
    }
}
