namespace Dominionizer.Sets
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
            this.Add(new Card(301, CardSet.Seaside, "Embargo", 2, 0, CardType.Action));
            this.Add(new Card(302, CardSet.Seaside, "Haven", 2, 0, CardType.Duration));
            this.Add(new Card(303, CardSet.Seaside, "Lighthouse", 2, 0, CardType.Duration));
            this.Add(new Card(304, CardSet.Seaside, "Native Village", 2, 0, CardType.Action));
            this.Add(new Card(305, CardSet.Seaside, "Pearl Diver", 2, 0, CardType.Action));

            this.Add(new Card(306, CardSet.Seaside, "Ambassador", 3, 0, CardType.Action));
            this.Add(new Card(307, CardSet.Seaside, "Fishing Village", 3, 0, CardType.Duration));
            this.Add(new Card(308, CardSet.Seaside, "Lookout", 3, 0, CardType.Action));
            this.Add(new Card(309, CardSet.Seaside, "Smugglers", 3, 0, CardType.Action));
            this.Add(new Card(310, CardSet.Seaside, "Warehouse", 3, 0, CardType.Action));

            this.Add(new Card(311, CardSet.Seaside, "Caravan", 4, 0, CardType.Duration));
            this.Add(new Card(312, CardSet.Seaside, "Cutpurse", 4, 0, CardType.Attack));
            this.Add(new Card(313, CardSet.Seaside, "Island", 4, 0, CardType.Victory));
            this.Add(new Card(314, CardSet.Seaside, "Navigator", 4, 0, CardType.Action));
            this.Add(new Card(315, CardSet.Seaside, "Pirate Ship", 4, 0, CardType.Attack));
            this.Add(new Card(316, CardSet.Seaside, "Salvager", 4, 0, CardType.Action));
            this.Add(new Card(317, CardSet.Seaside, "Sea Hag", 4, 0, CardType.Action));
            this.Add(new Card(318, CardSet.Seaside, "Treasure Map", 4, 0, CardType.Action));

            this.Add(new Card(319, CardSet.Seaside, "Bazaar", 5, 0, CardType.Action));
            this.Add(new Card(320, CardSet.Seaside, "Explorer", 5, 0, CardType.Action));
            this.Add(new Card(321, CardSet.Seaside, "Ghost Ship", 5, 0, CardType.Attack));
            this.Add(new Card(322, CardSet.Seaside, "Merchant Ship", 5, 0, CardType.Duration));
            this.Add(new Card(323, CardSet.Seaside, "Outpost", 5, 0, CardType.Duration));
            this.Add(new Card(324, CardSet.Seaside, "Tactician", 5, 0, CardType.Duration));
            this.Add(new Card(325, CardSet.Seaside, "Treasury", 5, 0, CardType.Action));
            this.Add(new Card(326, CardSet.Seaside, "Wharf", 5, 0, CardType.Duration));
        }
    }
}