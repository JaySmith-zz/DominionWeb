namespace Dominionizer.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;

    using Dominionizer.Web.Core;
    using Dominionizer.Web.Models;

    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new IndexViewModel();
            model.Parameters = new GameParameters();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(GameParameters parameters)
        {
            var model = new IndexViewModel { Parameters = parameters };

            if (model.IsValid())
            {

                var game = new GameGenerator();
                var cards = game.GetGameCards(MapGameParametersToGameGeneratorParameters(parameters));

                if (parameters.SortBy == "Cost") model.Cards = cards.OrderBy(x => x.Cost).ToList();
                else if (parameters.SortBy == "Name") model.Cards = cards.OrderBy(x => x.Name).ToList();
                else if (parameters.SortBy == "Set") model.Cards = cards.OrderBy(x => x.Set).ToList();
                else model.Cards = cards.ToList();
            }
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        private static GameGeneratorParameters MapGameParametersToGameGeneratorParameters(GameParameters parameters)
        {
            var gameGeneratorParameters = new GameGeneratorParameters
                {
                    Alchemy = parameters.Alchemy,
                    Dominion = parameters.Base,
                    Intrigue = parameters.Intrigue,
                    Promo = parameters.Promo,
                    Prosperity = parameters.Prosperity,
                    RequireReactionToAttack = parameters.RequireReactionToAttack,
                    RequireTwoToFiveCostCards = parameters.RequireTwoToFiveCostCards,
                    Seaside = parameters.Seaside
                };

            return gameGeneratorParameters;
        }

    }
}
