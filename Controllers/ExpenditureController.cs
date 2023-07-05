using Microsoft.AspNetCore.Mvc;
using RazorPrix.Models;

namespace RazorPrix.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            List<Expenditure> expenditures = new List<Expenditure>
            {
                new Expenditure("Cafe", new DateTime(2023,4,17), 5),
                new Expenditure("Sucre", new DateTime(2023,5,21), 2),
                new Expenditure("Riz", new DateTime(2023,1,6), 7)
            };
            double Count = 0;

            foreach(Expenditure exp in expenditures)
            {
                Count = Count + exp.Prix;
            }
            ViewData["Count"] = Count;

            return View(expenditures);
        }
    }
}
