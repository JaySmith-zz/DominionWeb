namespace Dominionizer.Web.Core.Sets
{
    using System.Collections.Generic;

    public class IntrigueCards : List<Card>
    {
        public IntrigueCards()
        {
            Initalize();
        }

        private void Initalize()
        {
            // Intrigue 200
            this.Add(new Card(26, CardSet.Intrigue, "Courtyard", 2, 0, CardType.Action));
            this.Add(new Card(27, CardSet.Intrigue, "Pawn", 2, 0, CardType.Action));
            this.Add(new Card(28, CardSet.Intrigue, "Secret Chamber", 2, 0, CardType.Reaction));
            this.Add(new Card(29, CardSet.Intrigue, "Great Hall", 2, 0, CardType.Victory));

            this.Add(new Card(30, CardSet.Intrigue, "Masquerade", 3, 0, CardType.Action));
            this.Add(new Card(31, CardSet.Intrigue, "Shanty Town", 3, 0, CardType.Action));
            this.Add(new Card(32, CardSet.Intrigue, "Steward", 3, 0, CardType.Action));
            this.Add(new Card(33, CardSet.Intrigue, "Swindler", 3, 0, CardType.Attack));
            this.Add(new Card(34, CardSet.Intrigue, "Wishing Well", 3, 0, CardType.Action));

            this.Add(new Card(35, CardSet.Intrigue, "Baron", 4, 0, CardType.Action));
            this.Add(new Card(36, CardSet.Intrigue, "Bridge", 4, 0, CardType.Action));
            this.Add(new Card(37, CardSet.Intrigue, "Conspirator", 4, 0, CardType.Action));
            this.Add(new Card(38, CardSet.Intrigue, "Ironworks", 4, 0, CardType.Action));
            this.Add(new Card(39, CardSet.Intrigue, "Mining Village", 4, 0, CardType.Action));
            this.Add(new Card(40, CardSet.Intrigue, "Scout", 4, 0, CardType.Action));

            this.Add(new Card(41, CardSet.Intrigue, "Duke", 5, 0, CardType.Victory));
            this.Add(new Card(42, CardSet.Intrigue, "Minion", 5, 0, CardType.Attack));
            this.Add(new Card(43, CardSet.Intrigue, "Saboteur", 5, 0, CardType.Attack));
            this.Add(new Card(44, CardSet.Intrigue, "Torturer", 5, 0, CardType.Action));
            this.Add(new Card(45, CardSet.Intrigue, "Trading Post", 5, 0, CardType.Action));
            this.Add(new Card(46, CardSet.Intrigue, "Tribute", 5, 0, CardType.Action));
            this.Add(new Card(47, CardSet.Intrigue, "Upgrade", 5, 0, CardType.Action));

            this.Add(new Card(48, CardSet.Intrigue, "Harem", 6, 0, CardType.Victory));
            this.Add(new Card(49, CardSet.Intrigue, "Nobles", 6, 0, CardType.Victory));
        }
    }
}