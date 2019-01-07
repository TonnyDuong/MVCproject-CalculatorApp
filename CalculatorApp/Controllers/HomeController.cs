using CalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Index(Operation Model)
        {
            string total = "Press CALCULATE when you're ready";

            switch (Model.SelectedFunction.ToLower())
            {
                case "add":
                    total = Convert.ToString(Model.InputA + Model.InputB);
                    break;
                case "subtract":
                    total = Convert.ToString(Model.InputA - Model.InputB);
                    break;
                case "multiply":
                    total = Convert.ToString(Model.InputA * Model.InputB);
                    break;
                case "divide":
                    total = Convert.ToString(Model.InputA / Model.InputB);
                    break;
                case "sin":
                    total = Convert.ToString(Math.Sin(Model.InputA));
                    break;
                case "cos":
                    total = Convert.ToString(Math.Cos(Model.InputA));
                    break;
                case "tan":
                    total = Convert.ToString(Math.Tan(Model.InputA));
                    break;
                case "atan":
                    total = Convert.ToString(Math.Atan(Model.InputA));
                    break;
                case "sqrt":
                    total = Convert.ToString(Math.Sqrt(Model.InputA));
                    break;
                case "power":
                    total = Convert.ToString(Math.Pow(Model.InputA, Model.InputB));
                    break;
                default: break;
            }

            Model.Answer = total;
            return View(Model);
        }
    }
}