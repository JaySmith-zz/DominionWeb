namespace Dominionizer.Web.Core.Sets
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
            this.Add(new Card(101, CardSet.Base, "Cellar", 2, 0, CardType.Action, 1,
                actionText: "Discard any number of cards.\n +1 Card per card discarded."));

            this.Add(new Card(102, CardSet.Base, "Chapel", 2, 0, CardType.Action,
                actionText: "Trash up to 4 cards from your hand."));

            this.Add(new Card(103, CardSet.Base, "Moat", 2, 0, CardType.Reaction, additionalCards: 2,
                actionText: "When another player plays an attack card, you may reveal this card from your hand.  If you do you are unaffected by the attack."));

            this.Add(new Card(104, CardSet.Base, "Chancellor", 3, 0, CardType.Action, additionalCoin: 2,
                actionText: "You may immediately put your deck into your discard pile."));

            this.Add(new Card(105, CardSet.Base, "Village", 3, 0, CardType.Action, additionalCards: 1, additionalActions: 2));

            this.Add(new Card(106, CardSet.Base, "Woodcutter", 3, 0, CardType.Action, additionalBuys: 1, additionalCoin: 2));

            this.Add(new Card(107, CardSet.Base, "Workshop", 3, 0, CardType.Action,
                actionText: "Gain a card costing up to 4."));

            this.Add(new Card(108, CardSet.Base, "Bureaucrat", 4, 0, CardType.Attack,
                actionText: "Gain a silver card; put it on top of your deck. Each other player reveals a Victory card from his hand and puts it on his deck (or reveals a hand with no Victory cards)."));

            this.Add(new Card(109, CardSet.Base, "Feast", 4, 0, CardType.Action,
                actionText: "Trash this card. Gain a card costing up to 5 Coins."));

            this.Add(new Card(110, CardSet.Base, "Gardens", 4, 0, CardType.Victory,
                actionText: "Worth 1 Victory for every 10 cards in your deck (rounded down)."));

            this.Add(new Card(111, CardSet.Base, "Militia", 4, 0, CardType.Attack, additionalCoin: 2,
                actionText: "Each other player discards down to 3 cards in his hand."));

            this.Add(new Card(112, CardSet.Base, "Moneylender", 4, 0, CardType.Action,
                actionText: "Trash a Copper from your hand. If you do, +3 Coins."));

            this.Add(new Card(113, CardSet.Base, "Remodel", 4, 0, CardType.Action,
                actionText: "Trash a card from your hand. Gain a card costing up to 2 Coins more than the trashed card."));

            this.Add(new Card(114, CardSet.Base, "Smithy", 4, 0, CardType.Action, additionalCards: 3));

            this.Add(new Card(115, CardSet.Base, "Spy", 4, 0, CardType.Attack, additionalCards: 1, additionalActions: 1,
                actionText: "Each player (including you) reveals the top card of his deck and either discards it or puts it back, your choice."));

            this.Add(new Card(116, CardSet.Base, "Thief", 4, 0, CardType.Attack,
                actionText: "Each other player reveals the top 2 cards of his deck. If they revealed any Treasure cards, they trash one of them that you choose. You may gain any or all of these trashed cards. They discard the other revealed cards."));

            this.Add(new Card(117, CardSet.Base, "Throne Room", 4, 0, CardType.Action,
                actionText: "Choose an Action card in your hand. Play it twice."));

            this.Add(new Card(119, CardSet.Base, "Council Room", 5, 0, CardType.Action, 4, 1,
                actionText: "Each other player draws a card."));

            this.Add(new Card(120, CardSet.Base, "Festival", 5, 0, CardType.Action, 2, 1, 0, 2));

            this.Add(new Card(121, CardSet.Base, "Laboratory", 5, 0, CardType.Action, 1, 0, 2));

            this.Add(new Card(121, CardSet.Base, "Library", 5, 0, CardType.Action, 
                actionText: "Draw until you have 7 cards in hand. You may set aside any Action cards drawn this way, as you draw them; discard the set aside cards after you finish drawing."));

            this.Add(new Card(122, CardSet.Base, "Market", 5, 0, CardType.Action, 1, 1, 1, 1));

            this.Add(new Card(123, CardSet.Base, "Mine", 5, 0, CardType.Action,
                actionText: "Trash a Treasure card from your hand. Gain a Treasure card costing up to 3 Coins more; put it into your hand."));

            this.Add(new Card(124, CardSet.Base, "Witch", 5, 0, CardType.Attack, additionalCards: 2,
                actionText: "Each other player gains a Curse card."));

            this.Add(new Card(125, CardSet.Base, "Adventurer", 6, 0, CardType.Action,
                actionText: "Reveal cards from your deck until you reveal 2 Treasure cards. Put those Treasure cards in your hand and discard the other revealed cards."));
        }
    }
}