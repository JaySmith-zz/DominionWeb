namespace Dominionizer.Sets
{
    using System.Collections.Generic;

    public class HinterlandsCards : List<Card>
    {
        /// <summary>
        /// Initializes a new instance of the HinterlandsCards class.
        /// </summary>
        public HinterlandsCards()
        {
            Initalize();
        }

        private void Initalize()
        {
            // Intrigue 200
            this.Add(new Card(701, CardSet.Hinterlands, "Crossroads", 2, 0, CardType.Action, 3, 0, 0, 0, "Reveal your hand. +1 Card per Victory card revealed. If this is the first time you played a Crossroads this turn, +3 Actions"));
            this.Add(new Card(702, CardSet.Hinterlands, "Duchess", 2, 0, CardType.Action, 0, 0, 0, 2, "Each player (including you) looks at the top card of his deck, and discards it or puts it back. In games using this, when you gain a Duchy, you may gain a Duchess."));
            this.Add(new Card(703, CardSet.Hinterlands, "Fool's Gold", 2, 0, CardType.Reaction, 0, 0, 0, 4, "If this is the first time you played a Fool’s Gold this turn, this is worth $1, otherwise it’s worth $4. When another player gains a Province, you may trash this from your hand. If you do, gain a Gold, putting it on your deck."));
            this.Add(new Card(704, CardSet.Hinterlands, "Develop", 3, 0, CardType.Action, 0, 0, 0, 0, "Trash a card from your hand. Gain a card costing exactly $1 more than it and a card costing exactly $1 less than it, in either order, putting them on top of your deck."));
            this.Add(new Card(705, CardSet.Hinterlands, "Oasis", 3, 0, CardType.Action, 1, 0, 1, 1, "Discard a card."));
            this.Add(new Card(706, CardSet.Hinterlands, "Oracle", 3, 0, CardType.Attack, 0, 0, 2, 0, "Each player (including you) reveals the top 2 cards of his deck, and you choose one: either he discards them, or he puts them back on top in an order he chooses."));
            this.Add(new Card(707, CardSet.Hinterlands, "Scheme", 3, 0, CardType.Action, 1, 0, 1, 0, "At the start of Clean-up this turn, you may choose an Action card you have in play. If you discard it from play this turn, put it on your deck."));
            this.Add(new Card(708, CardSet.Hinterlands, "Tunnel", 3, 0, CardType.Reaction, 0, 0, 0, 0, "2 Victory Points. When you discard this other than during a Clean-up phase, you may reveal it. If you do, gain a Gold."));
            this.Add(new Card(709, CardSet.Hinterlands, "Jack of All Trades", 4, 0, CardType.Action, 0, 0, 0, 0, "Gain a Silver. Look at the top card of your deck; discard it or put it back. Draw until you have 5 cards in hand. You may trash a card from your hand that is not a Treasure."));
            this.Add(new Card(710, CardSet.Hinterlands, "Noble Brigand", 4, 0, CardType.Attack, 0, 0, 0, 1, "When you buy this or play it, each other player reveals the top 2 cards of his deck, trashes a revealed Silver or Gold you choose, and discards the rest. If he didn’t reveal a Treasure, he gains a Copper. You gain the trashed cards."));
            this.Add(new Card(711, CardSet.Hinterlands, "Nomad Camp", 4, 0, CardType.Action, 0, 1, 0, 2, "When you gain this, put it on top of your deck."));
            this.Add(new Card(712, CardSet.Hinterlands, "Silk Road", 4, 0, CardType.Victory, 0, 0, 0, 0, "Worth 1 Victory Point for every 4 Victory cards in your deck (round down)."));
            this.Add(new Card(713, CardSet.Hinterlands, "Spice Merchant", 4, 0, CardType.Action, 0, 0, 0, 0, "You may trash a Treasure from your hand. If you do, choose one: +2 Cards and +1 Action; or +$2 and +1 Buy."));
            this.Add(new Card(714, CardSet.Hinterlands, "Trader", 4, 0, CardType.Reaction, 0, 0, 0, 0, "Trash a card from your hand. Gain a number of Silvers equal to its cost in coins. When you would gain a card, you may reveal this from your hand. If you do, instead, gain a silver."));
            this.Add(new Card(715, CardSet.Hinterlands, "Cache", 5, 0, CardType.Treasure, 0, 0, 0, 3, "When you gain this, gain two Coppers."));
            this.Add(new Card(716, CardSet.Hinterlands, "Cartographer", 5, 0, CardType.Action, 1, 0, 1, 0, "Look at the top 4 cards of your deck. Discard any number of them. Put the rest back on top in any order."));
            this.Add(new Card(717, CardSet.Hinterlands, "Embassy", 5, 0, CardType.Action, 0, 0, 5, 0, "Discard 3 cards. When you gain this, each other player gains a Silver."));
            this.Add(new Card(718, CardSet.Hinterlands, "Haggler", 5, 0, CardType.Action, 0, 0, 0, 2, "While this is in play, when you buy a card, gain a card costing less than it that is not a Victory card."));
            this.Add(new Card(719, CardSet.Hinterlands, "Highway", 5, 0, CardType.Action, 1, 0, 1, 0, "While this is in play, cards cost $1 less, but not less than $0."));
            this.Add(new Card(720, CardSet.Hinterlands, "Ill-Gotten Gains", 5, 0, CardType.Treasure, 0, 0, 0, 1, "When you play this, you may gain a Copper, putting it into your hand. When you gain this, each other player gains a Curse."));
            this.Add(new Card(721, CardSet.Hinterlands, "Inn", 5, 0, CardType.Action, 2, 0, 2, 0, "Discard 2 cards. When you gain this, look through your discard pile (including this), reveal any number of Action cards from it, and shuffle them into your deck."));
            this.Add(new Card(722, CardSet.Hinterlands, "Mandarin", 5, 0, CardType.Action, 0, 0, 0, 3, "Put a card from your hand on top of your deck. When you gain this, put all Treasures you have in play on top of your deck in any order."));
            this.Add(new Card(723, CardSet.Hinterlands, "Margrave", 5, 0, CardType.Attack, 0, 1, 3, 0, "Each other player draws a card, then discards down to 3 cards in hand."));
            this.Add(new Card(724, CardSet.Hinterlands, "Stables", 5, 0, CardType.Action, 1, 0, 3, 0, "You may discard a Treasure. If you do, +3 Cards and +1 Action."));
            this.Add(new Card(725, CardSet.Hinterlands, "Border Village", 6, 0, CardType.Action, 2, 0, 1, 0, "When you gain this, gain a card costing less than this."));
            this.Add(new Card(726, CardSet.Hinterlands, "Farmland", 6, 0, CardType.Victory, 0, 0, 0, 0, "2 Victory Points. When you buy this, trash a card from your hand. Gain a card costing exactly $2 more than the trashed card."));
        }
    }
}