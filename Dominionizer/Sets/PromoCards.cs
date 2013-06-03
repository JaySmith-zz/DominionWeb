namespace Dominionizer.Sets
{
    using System.Collections.Generic;

    public class BlackMarketCards : List<Card>
    {
        public BlackMarketCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Promo Cards 1000
            this.Add(new Card(1001, CardSet.BlackMarket, "Black Market", 3, 0, CardType.Action));
        }
    }

    public class EnvoyCards : List<Card>
    {
        public EnvoyCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.Add(new Card(1002, CardSet.Envoy, "Envoy", 4, 0, CardType.Action));
        }
    }

    public class StashCards : List<Card>
    {
        public StashCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.Add(new Card(1003, CardSet.Stash, "Stash", 5, 0, CardType.Treasure));
        }
    }

    public class WalledVilliageCards : List<Card>
    {
        public WalledVilliageCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.Add(new Card(1004, CardSet.WalledVillage, "Walled Village", 4, 0, CardType.Action));
        }
    }
}