namespace Dominionizer.Web.Core.Sets
{
    using System.Collections.Generic;

    public class SeasideCards : List<Card>
    {
        public SeasideCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Seaside 300
            this.Add(new Card(50, CardSet.Seaside, "Embargo", 2, 0, CardType.Action));
            this.Add(new Card(51, CardSet.Seaside, "Haven", 2, 0, CardType.Duration));
            this.Add(new Card(52, CardSet.Seaside, "Lighthouse", 2, 0, CardType.Duration));
            this.Add(new Card(53, CardSet.Seaside, "Native Village", 2, 0, CardType.Action));
            this.Add(new Card(54, CardSet.Seaside, "Pearl Diver", 2, 0, CardType.Action));

            this.Add(new Card(55, CardSet.Seaside, "Ambassador", 3, 0, CardType.Action));
            this.Add(new Card(56, CardSet.Seaside, "Fishing Village", 3, 0, CardType.Duration));
            this.Add(new Card(57, CardSet.Seaside, "Lookout", 3, 0, CardType.Action));
            this.Add(new Card(58, CardSet.Seaside, "Smugglers", 3, 0, CardType.Action));
            this.Add(new Card(59, CardSet.Seaside, "Warehouse", 3, 0, CardType.Action));

            this.Add(new Card(60, CardSet.Seaside, "Caravan", 4, 0, CardType.Duration));
            this.Add(new Card(61, CardSet.Seaside, "Cutpurse", 4, 0, CardType.Attack));
            this.Add(new Card(62, CardSet.Seaside, "Island", 4, 0, CardType.Victory));
            this.Add(new Card(63, CardSet.Seaside, "Navigator", 4, 0, CardType.Action));
            this.Add(new Card(64, CardSet.Seaside, "Pirate Ship", 4, 0, CardType.Attack));
            this.Add(new Card(65, CardSet.Seaside, "Salvager", 4, 0, CardType.Action));
            this.Add(new Card(66, CardSet.Seaside, "Sea Hag", 4, 0, CardType.Action));
            this.Add(new Card(67, CardSet.Seaside, "Treasure Map", 4, 0, CardType.Action));

            this.Add(new Card(68, CardSet.Seaside, "Bazaar", 5, 0, CardType.Action));
            this.Add(new Card(69, CardSet.Seaside, "Explorer", 5, 0, CardType.Action));
            this.Add(new Card(70, CardSet.Seaside, "Ghost Ship", 5, 0, CardType.Attack));
            this.Add(new Card(71, CardSet.Seaside, "Merchant Ship", 5, 0, CardType.Duration));
            this.Add(new Card(72, CardSet.Seaside, "Outpost", 5, 0, CardType.Duration));
            this.Add(new Card(73, CardSet.Seaside, "Tactician", 5, 0, CardType.Duration));
            this.Add(new Card(74, CardSet.Seaside, "Treasury", 5, 0, CardType.Action));
            this.Add(new Card(75, CardSet.Seaside, "Wharf", 5, 0, CardType.Duration));
        }
    }
}