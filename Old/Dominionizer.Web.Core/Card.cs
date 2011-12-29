namespace Dominionizer.Web.Core
{
    public class Card
    {
        public Card(
            int id,
            CardSet cardSet,
            string name,
            int cost,
            int potionCost,
            CardType cardType,
            int additionalActions = 0,
            int additionalBuys = 0,
            int additionalCards = 0,
            int additionalCoin = 0,
            string actionText = null)
        {
            this.Id = id;
            this.Set = cardSet;
            this.Name = name;
            this.Cost = cost;
            this.PotionCost = potionCost;
            this.Type = cardType;

            this.ActionText = actionText;
            AdditionalActions = additionalActions;
            AdditionalBuys = additionalBuys;
            AdditinalCards = additionalCards;
            AdditionalCoin = additionalCoin;
        }

        public int Id { get; set; }
        public CardSet Set { get; set; }
        public string Name { get; set; }
        public string ActionText { get; set; }
        public int AdditionalActions { get; set; }
        public int AdditionalBuys { get; set; }
        public int AdditinalCards { get; set; }
        public int AdditionalCoin { get; set; }
        public int Cost { get; set; }
        public int PotionCost { get; set; }
        public CardType Type { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var card = obj as Card;
            if (card == null) return false;

            return (Id == card.Id);
        }

        public static bool operator ==(Card a, Card b)
        {
            if (ReferenceEquals(a, b)) return true;

            if (((object)a == null) || ((object)b == null)) return false;

            return (a.Id == b.Id);
        }

        public static bool operator !=(Card a, Card b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}