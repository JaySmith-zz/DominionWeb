namespace Dominionizer.Sets
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
            this.Add(new Card(401, CardSet.Alchemy, "Transmute", 0, 1, CardType.Action));
            this.Add(new Card(402, CardSet.Alchemy, "Vineyard", 0, 1, CardType.Victory));

            this.Add(new Card(403, CardSet.Alchemy, "Apothecary", 2, 1, CardType.Action));
            this.Add(new Card(404, CardSet.Alchemy, "Herbalist", 2, 0, CardType.Action));
            this.Add(new Card(405, CardSet.Alchemy, "Scrying Pool", 2, 1, CardType.Attack));
            this.Add(new Card(406, CardSet.Alchemy, "University", 2, 1, CardType.Action));

            this.Add(new Card(408, CardSet.Alchemy, "Alchemist", 3, 1, CardType.Action));
            this.Add(new Card(409, CardSet.Alchemy, "Familiar", 3, 1, CardType.Attack));
            this.Add(new Card(410, CardSet.Alchemy, "Philosopher's Stone", 3, 1, CardType.Action));

            this.Add(new Card(411, CardSet.Alchemy, "Golem", 4, 1, CardType.Action));
            //this.Add(new Card(86, CardSet.Alchemy, "Potion", 4, 0, CardType.Treasure));

            this.Add(new Card(412, CardSet.Alchemy, "Apprentice", 5, 0, CardType.Action));

            this.Add(new Card(413, CardSet.Alchemy, "Possession", 6, 1, CardType.Action));
        }
    }
}