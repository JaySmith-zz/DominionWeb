namespace Dominionizer.Web.Core.Sets
{
    using System.Collections.Generic;

    public class PromoCards : List<Card>
    {
        public PromoCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Promo Cards 1000
            this.Add(new Card(1001, CardSet.Promo, "Black Market", 3, 0, CardType.Action));
            this.Add(new Card(1002, CardSet.Promo, "Envoy", 4, 0, CardType.Action));
            this.Add(new Card(1003, CardSet.Promo, "Stash", 5, 0, CardType.Treasure));
        }
    }
}