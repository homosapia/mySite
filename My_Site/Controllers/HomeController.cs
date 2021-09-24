using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTestTaskEasy.Scripts;
using WebTestTaskEasy.Model;
using WebTestTaskEasy.Objects;
using WebTestTaskEasy.Interface;
using Microsoft.Extensions.DependencyInjection;
using WebTestTaskEasy.Service;

namespace WebTestTaskEasy.Co
{
    public class HomeController : Controller
    {
        IReferee referee;

        public HomeController(IReferee referee)
        {
            this.referee = referee;
        }

        public IActionResult GameActivation()
        {
            Game model = new();

            HttpContext.Session.SaveGame(model);
            return View("~/Views/Home/StartRound.cshtml", model);
        }

        [HttpPost]
        public IActionResult NewRound()
        {
            Game model = HttpContext.Session.LoadGame();

            model.PredictionsPsychics();

            HttpContext.Session.SaveGame(model);
            return RedirectToAction("EnterNumber");
        }

        public IActionResult EnterNumber()
        {
            Game model = HttpContext.Session.LoadGame();

            return View(model);
        }

        [HttpPost]
        public IActionResult EndRound(int number)
        {
            Game model = HttpContext.Session.LoadGame();

            model.FinishRound(number);

            HttpContext.Session.SaveGame(model);
            return RedirectToAction("StartRound");
        }

        public IActionResult StartRound()
        {
            Game model = HttpContext.Session.LoadGame();

            return View(model);
        }
    }
}