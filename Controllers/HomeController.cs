
using DojoSurveyModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyModelValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(Survey survey)
        {
            if (ModelState.IsValid)
            {
                return View(survey);
            }
            else
            {
                return View("Index");
            }
        }
    }
}