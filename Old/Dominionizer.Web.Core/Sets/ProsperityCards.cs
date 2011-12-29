namespace Dominionizer.Web.Core.Sets
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
            this.Add(new Card(89, CardSet.Prosperity, "Loan", 3, 0, CardType.Treasure));
            this.Add(new Card(90, CardSet.Prosperity, "Trade Route", 3, 0, CardType.Action));
            this.Add(new Card(91, CardSet.Prosperity, "Watchtower", 3, 0, CardType.Reaction));

            this.Add(new Card(92, CardSet.Prosperity, "Bishop", 4, 0, CardType.Action));
            this.Add(new Card(93, CardSet.Prosperity, "Monument", 4, 0, CardType.Action));
            this.Add(new Card(94, CardSet.Prosperity, "Quarry", 4, 0, CardType.Treasure));
            this.Add(new Card(95, CardSet.Prosperity, "Talisman", 4, 0, CardType.Treasure));
            this.Add(new Card(96, CardSet.Prosperity, "Worker's Village", 4, 0, CardType.Action));

            this.Add(new Card(97, CardSet.Prosperity, "City", 5, 0, CardType.Action));
            this.Add(new Card(98, CardSet.Prosperity, "Contraband", 5, 0, CardType.Treasure));
            this.Add(new Card(99, CardSet.Prosperity, "Counting House", 5, 0, CardType.Action));
            this.Add(new Card(100, CardSet.Prosperity, "Mint", 5, 0, CardType.Action));
            this.Add(new Card(101, CardSet.Prosperity, "Mountebank", 5, 0, CardType.Attack));
            this.Add(new Card(102, CardSet.Prosperity, "Rabble", 5, 0, CardType.Attack));
            this.Add(new Card(103, CardSet.Prosperity, "Royal Seal", 5, 0, CardType.Treasure));
            this.Add(new Card(104, CardSet.Prosperity, "Vault", 5, 0, CardType.Action));
            this.Add(new Card(105, CardSet.Prosperity, "Venture", 5, 0, CardType.Treasure));

            this.Add(new Card(106, CardSet.Prosperity, "Goons", 6, 0, CardType.Attack));
            this.Add(new Card(107, CardSet.Prosperity, "Grand Market", 6, 0, CardType.Action));
            this.Add(new Card(108, CardSet.Prosperity, "Hoard", 6, 0, CardType.Treasure));

            this.Add(new Card(109, CardSet.Prosperity, "Bank", 7, 0, CardType.Treasure));
            this.Add(new Card(110, CardSet.Prosperity, "Expand", 7, 0, CardType.Action));
            this.Add(new Card(111, CardSet.Prosperity, "Forge", 7, 0, CardType.Action));
            this.Add(new Card(112, CardSet.Prosperity, "King's Court", 7, 0, CardType.Action));

            this.Add(new Card(113, CardSet.Prosperity, "Peddler", 8, 0, CardType.Action));

            // this.Add(new Card(114, CardSet.Prosperity, "Platinum", 9, 0, CardType.Treasure));

            // this.Add(new Card(115, CardSet.Prosperity, "Colony", 10, 0, CardType.Victory));
        }
    }
}