namespace DominionWeb.Controllers
{
    using System.Web.Mvc;
    using System.Linq;

    using Dominionizer;

    using DominionWeb.Models;

    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new IndexViewModel {Parameters = new GameParameters()};

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(GameParameters parameters)
        {
            var model = new IndexViewModel { Parameters = parameters };

            if (model.IsValid())
            {
                var game = new GameGenerator();
                var gameGeneratorParameters = MapGameParametersToGameGeneratorParameters(parameters);
                var cards = game.GetGameCards(gameGeneratorParameters);

                switch (parameters.SortBy)
                {
                    case "Cost":
                        model.Cards = cards.OrderBy(x => x.Cost).ToList();
                        break;
                    case "Name":
                        model.Cards = cards.OrderBy(x => x.Name).ToList();
                        break;
                    case "Set":
                        model.Cards = cards.OrderBy(x => x.Set).ToList();
                        break;
                    default:
                        model.Cards = cards.ToList();
                        break;
                }
            }
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        private static GameGeneratorParameters MapGameParametersToGameGeneratorParameters(GameParameters parameters)
        {
            var gameParamaters = GameGeneratorParameters.GetInstance();

            if (parameters.Base) gameParamaters.FindSet("Dominion").IsSet = true;
            if (parameters.Alchemy) gameParamaters.FindSet("Alchemy").IsSet = true;
            if (parameters.Intrigue) gameParamaters.FindSet("Intrigue").IsSet = true;
            if (parameters.Promo) gameParamaters.FindSet("Promo").IsSet = true;
            if (parameters.Prosperity) gameParamaters.FindSet("Prosperity").IsSet = true;
            if (parameters.Seaside) gameParamaters.FindSet("Seaside").IsSet = true;
            if (parameters.Cornucopia) gameParamaters.FindSet("Cornucopia").IsSet = true;
            if (parameters.Hinterlands) gameParamaters.FindSet("Hinterlands").IsSet = true;
            if (parameters.DarkAges) gameParamaters.FindSet("DarkAges").IsSet = true;

            if (parameters.RequireReactionToAttack) gameParamaters.FindRule("RequireReactionToAttack").IsSet = true;
            if (parameters.RequireTwoToFiveCostCards) gameParamaters.FindRule("RequireTwoToFiveCostCards").IsSet = true;

            return gameParamaters;
        }

    }
}
