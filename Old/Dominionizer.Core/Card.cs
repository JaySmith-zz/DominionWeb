namespace Dominionizer.Phone.Core
{
    public class Card
    {
        public Card(int id, CardSet cardSet, string name, int cost, int potionCost, CardType cardType)
        {
            this.Id = id;
            this.Set = cardSet;
            this.Name = name;
            this.Cost = cost;
            this.PotionCost = potionCost;
            this.Type = cardType;
        }

        public int Id { get; set; }
        public CardSet Set { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int PotionCost { get; set; }
        public CardType Type { get; set; }
    }
}