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
        readonly IGameFactory gameFactory;
        readonly IGameStorage gameStorage;
        public HomeController(IGameFactory gameFactory, IGameStorage gameStorage)
        {
            this.gameFactory = gameFactory;
            this.gameStorage = gameStorage;
        }

        public IActionResult GameActivation()
        {
            Game game = gameFactory.Create();
            gameStorage.SetGame(game);
            return View("~/Views/Home/StartRound.cshtml", game);
        }

        [HttpPost]
        public IActionResult NewRound()
        {
            Game game = gameFactory.Create();
            game.PredictionsPsychics();

            gameStorage.SetGame(game);
            return RedirectToAction("EnterNumber");
        }

        public IActionResult EnterNumber()
        {
            return View(gameFactory.Create());
        }

        [HttpPost]
        public IActionResult EndRound(int number)
        {
            Game game = gameFactory.Create();

            game.FinishRound(number);

            gameStorage.SetGame(game);
            return RedirectToAction("StartRound");
        }

        public IActionResult StartRound()
        {
            return View(gameFactory.Create());
        }
    }
}