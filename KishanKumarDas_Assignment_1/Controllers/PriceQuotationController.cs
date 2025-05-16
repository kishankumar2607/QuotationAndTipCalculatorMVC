using KishanKumarDas_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KishanKumarDas_Assignment_1.Controllers
{
    public class PriceQuotationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new PriceQuotationModel());
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }

        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}
