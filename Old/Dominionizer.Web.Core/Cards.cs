namespace Dominionizer.Web.Core
{
    using System.Collections.Generic;

    using Dominionizer.Web.Core.Sets;

    public class Cards : List<Card>
    {
        public Cards()
        {
            this.AddRange(new DominionCards());
            this.AddRange(new AlchemyCards());
            this.AddRange(new IntrigueCards());
            this.AddRange(new PromoCards());
            this.AddRange(new ProsperityCards());
            this.AddRange(new SeasideCards());
        }
    }
}