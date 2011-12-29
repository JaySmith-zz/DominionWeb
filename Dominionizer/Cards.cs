namespace Dominionizer
{
    using System.Collections.Generic;

    using Dominionizer.Sets;

    public class Cards : List<Card>
    {
        public Cards()
        {
            // Standard Sets
            this.AddRange(new DominionCards());
            this.AddRange(new IntrigueCards());
            this.AddRange(new SeasideCards());
            this.AddRange(new AlchemyCards());
            this.AddRange(new ProsperityCards());
            this.AddRange(new CornucopiaCards());
            this.AddRange(new HinterlandsCards());

            // Promo Cards
            this.AddRange(new BlackMarketCards());
            this.AddRange(new EnvoyCards());
            this.AddRange(new StashCards());
            this.AddRange(new WalledVilliageCards());
        }
    }
}