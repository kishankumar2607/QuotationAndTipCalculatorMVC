using KishanKumarDas_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KishanKumarDas_Assignment_1.Controllers
{
    public class TipCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel tcModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = tcModel.TipCost15?.ToString("F2") ?? "0.00";
                ViewBag.Tip20 = tcModel.TipCost20?.ToString("F2") ?? "0.00";
                ViewBag.Tip25 = tcModel.TipCost25?.ToString("F2") ?? "0.00";
            }
            return View(tcModel);
        }
    }
}
