namespace Dominionizer.Web.Core.Sets
{
    using System.Collections.Generic;

    public class AlchemyCards : List<Card>
    {
        public AlchemyCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Alchemy 400
            this.Add(new Card(76, CardSet.Alchemy, "Transmute", 0, 1, CardType.Action));
            this.Add(new Card(77, CardSet.Alchemy, "Vinyard", 0, 1, CardType.Victory));

            this.Add(new Card(78, CardSet.Alchemy, "Apothecary", 2, 1, CardType.Action));
            this.Add(new Card(79, CardSet.Alchemy, "Herbalist", 2, 0, CardType.Action));
            this.Add(new Card(80, CardSet.Alchemy, "Scrying Pool", 2, 1, CardType.Attack));
            this.Add(new Card(81, CardSet.Alchemy, "University", 2, 1, CardType.Action));

            this.Add(new Card(82, CardSet.Alchemy, "Alchemist", 3, 1, CardType.Action));
            this.Add(new Card(83, CardSet.Alchemy, "Familiar", 3, 1, CardType.Attack));
            this.Add(new Card(84, CardSet.Alchemy, "Philosopher's Stone", 3, 1, CardType.Action));

            this.Add(new Card(85, CardSet.Alchemy, "Golem", 4, 1, CardType.Action));
            this.Add(new Card(86, CardSet.Alchemy, "Potion", 4, 0, CardType.Treasure));

            this.Add(new Card(87, CardSet.Alchemy, "Apprentice", 5, 0, CardType.Action));

            this.Add(new Card(88, CardSet.Alchemy, "Possesion", 6, 1, CardType.Action));
        }
    }
}