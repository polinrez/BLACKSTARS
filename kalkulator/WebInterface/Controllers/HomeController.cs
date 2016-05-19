using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kalkulator.TwoArgument;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.operations = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = "button1", Text = "Сложение"
                },
                new SelectListItem()
                {
                    Value = "button2", Text = "Вычитание"
                },
                new SelectListItem()
                {
                    Value = "button3", Text = "Умножение"
                },
                new SelectListItem()
                {
                    Value = "button4", Text = "Деление"
                }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(string operation, double first, double second)
        {
            try
            {
                ICalculator calculator = Factory.CreateCalculator(operation);
                double result = calculator.Calculate(first, second);

                TempData["result"] = result;
            }
            catch (Exception e)
            {
                TempData["result"] = e.Message;
            }
            
            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            ViewBag.result = TempData["result"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}