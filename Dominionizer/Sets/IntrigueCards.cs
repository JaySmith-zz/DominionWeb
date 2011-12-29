namespace Dominionizer.Sets
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
            this.Add(new Card(201, CardSet.Intrigue, "Courtyard", 2, 0, CardType.Action));
            this.Add(new Card(202, CardSet.Intrigue, "Pawn", 2, 0, CardType.Action));
            this.Add(new Card(203, CardSet.Intrigue, "Secret Chamber", 2, 0, CardType.Reaction));
            this.Add(new Card(204, CardSet.Intrigue, "Great Hall", 2, 0, CardType.Victory));

            this.Add(new Card(205, CardSet.Intrigue, "Masquerade", 3, 0, CardType.Action));
            this.Add(new Card(206, CardSet.Intrigue, "Shanty Town", 3, 0, CardType.Action));
            this.Add(new Card(207, CardSet.Intrigue, "Steward", 3, 0, CardType.Action));
            this.Add(new Card(208, CardSet.Intrigue, "Swindler", 3, 0, CardType.Attack));
            this.Add(new Card(209, CardSet.Intrigue, "Wishing Well", 3, 0, CardType.Action));

            this.Add(new Card(210, CardSet.Intrigue, "Baron", 4, 0, CardType.Action));
            this.Add(new Card(211, CardSet.Intrigue, "Bridge", 4, 0, CardType.Action));
            this.Add(new Card(212, CardSet.Intrigue, "Conspirator", 4, 0, CardType.Action));
            this.Add(new Card(213, CardSet.Intrigue, "Ironworks", 4, 0, CardType.Action));
            this.Add(new Card(214, CardSet.Intrigue, "Mining Village", 4, 0, CardType.Action));
            this.Add(new Card(215, CardSet.Intrigue, "Scout", 4, 0, CardType.Action));

            this.Add(new Card(216, CardSet.Intrigue, "Duke", 5, 0, CardType.Victory));
            this.Add(new Card(217, CardSet.Intrigue, "Minion", 5, 0, CardType.Attack));
            this.Add(new Card(218, CardSet.Intrigue, "Saboteur", 5, 0, CardType.Attack));
            this.Add(new Card(219, CardSet.Intrigue, "Torturer", 5, 0, CardType.Action));
            this.Add(new Card(220, CardSet.Intrigue, "Trading Post", 5, 0, CardType.Action));
            this.Add(new Card(221, CardSet.Intrigue, "Tribute", 5, 0, CardType.Action));
            this.Add(new Card(222, CardSet.Intrigue, "Upgrade", 5, 0, CardType.Action));

            this.Add(new Card(223, CardSet.Intrigue, "Harem", 6, 0, CardType.Victory));
            this.Add(new Card(224, CardSet.Intrigue, "Nobles", 6, 0, CardType.Victory));
            this.Add(new Card(225, CardSet.Intrigue, "Coppersmith", 4, 0, CardType.Action));
        }
    }
}