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
        public HomeController(IGameFactory gameFactory)
        {
            this.gameFactory = gameFactory;
        }

        public IActionResult ActivationGame()
        {
            Game game;
            if (gameFactory.SessionExists())
                game = gameFactory.GetGame();
            else
                game = gameFactory.NewGame();

            gameFactory.SetGame(game);
            return View("~/Views/Home/StartRound.cshtml", game);
        }

        [HttpPost]
        public IActionResult NewRound()
        {
            Game game = gameFactory.GetGame();
            game.ÑreateNewRound();
            game.AskPsychics();

            gameFactory.SetGame(game);
            return RedirectToAction("EnterNumber");
        }

        public IActionResult EnterNumber()
        {
            return View(gameFactory.GetGame());
        }

        [HttpPost]
        public IActionResult EndRound(int number)
        {
            if (IsUserNumberInvalid(number))
            {
                return RedirectToAction("EnterNumber");
            }

            Game game = gameFactory.GetGame();
            game.FinishRound(number);

            gameFactory.SetGame(game);
            return RedirectToAction("StartRound");
        }

        private bool IsUserNumberInvalid(int number)
        {
            return number < Game.Min || number > Game.Max;
        }

        public IActionResult StartRound()
        {
            return View(gameFactory.GetGame());
        }
    }
}