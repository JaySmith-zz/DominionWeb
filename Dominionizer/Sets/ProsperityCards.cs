namespace Dominionizer.Sets
{
    using System.Collections.Generic;

    public class ProsperityCards : List<Card>
    {
        public ProsperityCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Prosperity 500
            this.Add(new Card(501, CardSet.Prosperity, "Loan", 3, 0, CardType.Treasure));
            this.Add(new Card(502, CardSet.Prosperity, "Trade Route", 3, 0, CardType.Action));
            this.Add(new Card(503, CardSet.Prosperity, "Watchtower", 3, 0, CardType.Reaction));

            this.Add(new Card(504, CardSet.Prosperity, "Bishop", 4, 0, CardType.Action));
            this.Add(new Card(505, CardSet.Prosperity, "Monument", 4, 0, CardType.Action));
            this.Add(new Card(506, CardSet.Prosperity, "Quarry", 4, 0, CardType.Treasure));
            this.Add(new Card(507, CardSet.Prosperity, "Talisman", 4, 0, CardType.Treasure));
            this.Add(new Card(508, CardSet.Prosperity, "Worker's Village", 4, 0, CardType.Action));

            this.Add(new Card(509, CardSet.Prosperity, "City", 5, 0, CardType.Action));
            this.Add(new Card(510, CardSet.Prosperity, "Contraband", 5, 0, CardType.Treasure));
            this.Add(new Card(511, CardSet.Prosperity, "Counting House", 5, 0, CardType.Action));
            this.Add(new Card(512, CardSet.Prosperity, "Mint", 5, 0, CardType.Action));
            this.Add(new Card(513, CardSet.Prosperity, "Mountebank", 5, 0, CardType.Attack));
            this.Add(new Card(514, CardSet.Prosperity, "Rabble", 5, 0, CardType.Attack));
            this.Add(new Card(515, CardSet.Prosperity, "Royal Seal", 5, 0, CardType.Treasure));
            this.Add(new Card(516, CardSet.Prosperity, "Vault", 5, 0, CardType.Action));
            this.Add(new Card(517, CardSet.Prosperity, "Venture", 5, 0, CardType.Treasure));

            this.Add(new Card(518, CardSet.Prosperity, "Goons", 6, 0, CardType.Attack));
            this.Add(new Card(519, CardSet.Prosperity, "Grand Market", 6, 0, CardType.Action));
            this.Add(new Card(520, CardSet.Prosperity, "Hoard", 6, 0, CardType.Treasure));

            this.Add(new Card(521, CardSet.Prosperity, "Bank", 7, 0, CardType.Treasure));
            this.Add(new Card(522, CardSet.Prosperity, "Expand", 7, 0, CardType.Action));
            this.Add(new Card(523, CardSet.Prosperity, "Forge", 7, 0, CardType.Action));
            this.Add(new Card(524, CardSet.Prosperity, "King's Court", 7, 0, CardType.Action));

            this.Add(new Card(525, CardSet.Prosperity, "Peddler", 8, 0, CardType.Action));
        }
    }
}