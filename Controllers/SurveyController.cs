using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyCS.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Survey()
        {
            return View("Survey");
        }

        [HttpPost("/process")]
        public RedirectToActionResult Process(
            string name,
            string dojoLocation,
            string favoriteLanguage,
            string comments
            )
        {
            return RedirectToAction(
                "Results", new {
                    name = name,
                    dojoLocation = dojoLocation,
                    favoriteLanguage = favoriteLanguage,
                    comments = comments
                    }
                );
        }

        [HttpGet("/results")]
        public ViewResult Results(
            string name,
            string dojoLocation,
            string favoriteLanguage,
            string comments
            )
        {
            ViewBag.name = name;
            ViewBag.dojoLocation = dojoLocation;
            ViewBag.favoriteLanguage = favoriteLanguage;
            ViewBag.comments = comments;
            return View("Results");
        }
    }
}