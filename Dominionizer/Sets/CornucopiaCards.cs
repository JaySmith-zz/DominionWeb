namespace Dominionizer.Sets
{
    using System.Collections.Generic;

    public class CornucopiaCards : List<Card>
    {
        public CornucopiaCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.Add(new Card(601, CardSet.Cornucopia, "Hamlet", 2, 0, CardType.Action, 1));
            this.Add(new Card(602, CardSet.Cornucopia, "Fortune Teller", 3, 0, CardType.Attack));
            this.Add(new Card(603, CardSet.Cornucopia, "Menagerie", 3, 0, CardType.Action));
            this.Add(new Card(604, CardSet.Cornucopia, "Farming Village", 4, 0, CardType.Action));
            this.Add(new Card(605, CardSet.Cornucopia, "Horse Traders", 4, 0, CardType.Reaction));
            this.Add(new Card(606, CardSet.Cornucopia, "Remake", 4, 0, CardType.Action));
            this.Add(new Card(607, CardSet.Cornucopia, "Tournament", 4, 0, CardType.Action));
            this.Add(new Card(608, CardSet.Cornucopia, "Young Witch", 4, 0, CardType.Attack));
            this.Add(new Card(609, CardSet.Cornucopia, "Harvest", 5, 0, CardType.Action));
            this.Add(new Card(610, CardSet.Cornucopia, "Horn of Plenty", 5, 0, CardType.Treasure));
            this.Add(new Card(611, CardSet.Cornucopia, "Hunting Party", 5, 0, CardType.Action));
            this.Add(new Card(612, CardSet.Cornucopia, "Jester", 5, 0, CardType.Attack));
            this.Add(new Card(613, CardSet.Cornucopia, "Fairgrounds", 6, 0, CardType.Victory));
        }
    }
}