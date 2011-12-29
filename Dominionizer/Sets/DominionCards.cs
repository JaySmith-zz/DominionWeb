namespace Dominionizer.Sets
{
    using System.Collections.Generic;

    public class DominionCards : List<Card>
    {
        public DominionCards()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.Add(new Card(101, CardSet.Dominion, "Cellar", 2, 0, CardType.Action, 1));
            this.Add(new Card(102, CardSet.Dominion, "Chapel", 2, 0, CardType.Action));
            this.Add(new Card(103, CardSet.Dominion, "Moat", 2, 0, CardType.Reaction));
            this.Add(new Card(104, CardSet.Dominion, "Chancellor", 3, 0, CardType.Action));
            this.Add(new Card(105, CardSet.Dominion, "Village", 3, 0, CardType.Action));
            this.Add(new Card(106, CardSet.Dominion, "Woodcutter", 3, 0, CardType.Action));
            this.Add(new Card(107, CardSet.Dominion, "Workshop", 3, 0, CardType.Action));
            this.Add(new Card(108, CardSet.Dominion, "Bureaucrat", 4, 0, CardType.Attack));
            this.Add(new Card(109, CardSet.Dominion, "Feast", 4, 0, CardType.Action));
            this.Add(new Card(110, CardSet.Dominion, "Gardens", 4, 0, CardType.Victory));
            this.Add(new Card(111, CardSet.Dominion, "Militia", 4, 0, CardType.Attack));
            this.Add(new Card(112, CardSet.Dominion, "Moneylender", 4, 0, CardType.Action));
            this.Add(new Card(113, CardSet.Dominion, "Remodel", 4, 0, CardType.Action));
            this.Add(new Card(114, CardSet.Dominion, "Smithy", 4, 0, CardType.Action));
            this.Add(new Card(115, CardSet.Dominion, "Spy", 4, 0, CardType.Attack));
            this.Add(new Card(116, CardSet.Dominion, "Thief", 4, 0, CardType.Attack));
            this.Add(new Card(117, CardSet.Dominion, "Throne Room", 4, 0, CardType.Action));
            this.Add(new Card(119, CardSet.Dominion, "Council Room", 5, 0, CardType.Action));
            this.Add(new Card(120, CardSet.Dominion, "Festival", 5, 0, CardType.Action));
            this.Add(new Card(121, CardSet.Dominion, "Laboratory", 5, 0, CardType.Action));
            this.Add(new Card(121, CardSet.Dominion, "Library", 5, 0, CardType.Action));
            this.Add(new Card(122, CardSet.Dominion, "Market", 5, 0, CardType.Action));
            this.Add(new Card(123, CardSet.Dominion, "Mine", 5, 0, CardType.Action));
            this.Add(new Card(124, CardSet.Dominion, "Witch", 5, 0, CardType.Attack));
            this.Add(new Card(125, CardSet.Dominion, "Adventurer", 6, 0, CardType.Action));
        }
    }
}