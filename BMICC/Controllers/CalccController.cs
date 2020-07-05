using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using BMICC.Models;

namespace BMICC.Controllers
{
    public class CalccController : Controller
    {
        // GET: Calcc
        public ActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]

        public ActionResult Index(calc c, string calculate)
        {
            Math.Round(c.result, 2);
            c.result = c.weight / (c.height / 100 * c.height / 100);

            if(c.result < 18.5)
            {
                c.implication = "You are underweight";
            }
            else if(c.result <= 24.9)
            {
                c.implication = "You are healthy";
            }
            else if(c.result <= 29.9)
            {
                c.implication = "You are overweight";

            }
            else
            {
                c.implication = "You are obese";
            }

            return View(c);
        }
    }
}