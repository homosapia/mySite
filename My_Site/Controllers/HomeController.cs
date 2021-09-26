using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTestTaskEasy.Scripts;
using WebTestTaskEasy.Objects;
using WebTestTaskEasy.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace WebTestTaskEasy.Co
{
    public class HomeController : Controller
    {
        Game game;

        public HomeController(Game _game)
        {
            game = _game;
        }

        public IActionResult GameActivation()
        {
            HttpContext.Session.SaveGame(game);
            return View("~/Views/Home/StartRound.cshtml", game);
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
            model._referee = game._referee;

            return View(model);
        }

        [HttpPost]
        public IActionResult EndRound(int number)
        {
            Game model  = HttpContext.Session.LoadGame();

            model.FinishRound(number);

            HttpContext.Session.SaveGame(model);
            return RedirectToAction("StartRound");
        }

        public IActionResult StartRound()
        {
            Game model = HttpContext.Session.LoadGame();
            model._referee = game._referee;

            return View(model);
        }
    }
}