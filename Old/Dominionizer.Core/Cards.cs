namespace Dominionizer.Phone.Core
{
    using System.Collections.Generic;

    public class Cards : List<Card>
    {
        public Cards()
        {
            InitializeCards();
        }

        private void InitializeCards()
        {
            // Base Set
            this.Add(new Card(1, CardSet.Base, "Cellar", 2, 0, CardType.Action));
            this.Add(new Card(2, CardSet.Base, "Chapel", 2, 0, CardType.Action));
            this.Add(new Card(3, CardSet.Base, "Moat", 2, 0, CardType.Reaction));

            this.Add(new Card(4, CardSet.Base, "Chancellor", 3, 0, CardType.Action));
            this.Add(new Card(5, CardSet.Base, "Village", 3, 0, CardType.Action));
            this.Add(new Card(6, CardSet.Base, "Woodcutter", 3, 0, CardType.Action));
            this.Add(new Card(7, CardSet.Base, "Workshop", 3, 0, CardType.Action));

            this.Add(new Card(8, CardSet.Base, "Bureaucrat", 4, 0, CardType.Attack));
            this.Add(new Card(9, CardSet.Base, "Feast", 4, 0, CardType.Action));
            this.Add(new Card(10, CardSet.Base, "Gardens", 4, 0, CardType.Victory));
            this.Add(new Card(11, CardSet.Base, "Militia", 4, 0, CardType.Attack));
            this.Add(new Card(12, CardSet.Base, "Moneylender", 4, 0, CardType.Action));
            this.Add(new Card(13, CardSet.Base, "Remodel", 4, 0, CardType.Action));
            this.Add(new Card(14, CardSet.Base, "Smithy", 4, 0, CardType.Action));
            this.Add(new Card(15, CardSet.Base, "Spy", 4, 0, CardType.Attack));
            this.Add(new Card(16, CardSet.Base, "Thief", 4, 0, CardType.Attack));
            this.Add(new Card(17, CardSet.Base, "Throne Room", 4, 0, CardType.Action));

            this.Add(new Card(19, CardSet.Base, "Council Room", 5, 0, CardType.Action));
            this.Add(new Card(20, CardSet.Base, "Festival", 5, 0, CardType.Action));
            this.Add(new Card(21, CardSet.Base, "Laboratory", 5, 0, CardType.Action));
            this.Add(new Card(22, CardSet.Base, "Market", 5, 0, CardType.Action));
            this.Add(new Card(23, CardSet.Base, "Mine", 5, 0, CardType.Action));
            this.Add(new Card(24, CardSet.Base, "Witch", 5, 0, CardType.Attack));

            this.Add(new Card(25, CardSet.Base, "Adventurer", 6, 0, CardType.Action));

            // Intrigue
            this.Add(new Card(26, CardSet.Intrigue, "Courtyard", 2, 0, CardType.Action));
            this.Add(new Card(27, CardSet.Intrigue, "Pawn", 2, 0, CardType.Action));
            this.Add(new Card(28, CardSet.Intrigue, "Secret Chamber", 2, 0, CardType.Reaction));
            this.Add(new Card(29, CardSet.Intrigue, "Great Hall", 2, 0, CardType.Victory));

            this.Add(new Card(30, CardSet.Intrigue, "Masquerade", 3, 0, CardType.Action));
            this.Add(new Card(31, CardSet.Intrigue, "Shanty Town", 3, 0, CardType.Action));
            this.Add(new Card(32, CardSet.Intrigue, "Steward", 3, 0, CardType.Action));
            this.Add(new Card(33, CardSet.Intrigue, "Swindler", 3, 0, CardType.Attack));
            this.Add(new Card(34, CardSet.Intrigue, "Wishing Well", 3, 0, CardType.Action));

            this.Add(new Card(35, CardSet.Intrigue, "Baron", 4, 0, CardType.Action));
            this.Add(new Card(36, CardSet.Intrigue, "Bridge", 4, 0, CardType.Action));
            this.Add(new Card(37, CardSet.Intrigue, "Conspirator", 4, 0, CardType.Action));
            this.Add(new Card(38, CardSet.Intrigue, "Ironworks", 4, 0, CardType.Action));
            this.Add(new Card(39, CardSet.Intrigue, "Mining Village", 4, 0, CardType.Action));
            this.Add(new Card(40, CardSet.Intrigue, "Scout", 4, 0, CardType.Action));

            this.Add(new Card(41, CardSet.Intrigue, "Duke", 5, 0, CardType.Victory));
            this.Add(new Card(42, CardSet.Intrigue, "Minion", 5, 0, CardType.Attack));
            this.Add(new Card(43, CardSet.Intrigue, "Saboteur", 5, 0, CardType.Attack));
            this.Add(new Card(44, CardSet.Intrigue, "Torturer", 5, 0, CardType.Action));
            this.Add(new Card(45, CardSet.Intrigue, "Trading Post", 5, 0, CardType.Action));
            this.Add(new Card(46, CardSet.Intrigue, "Tribute", 5, 0, CardType.Action));
            this.Add(new Card(47, CardSet.Intrigue, "Upgrade", 5, 0, CardType.Action));

            this.Add(new Card(48, CardSet.Intrigue, "Harem", 6, 0, CardType.Victory));
            this.Add(new Card(49, CardSet.Intrigue, "Nobles", 6, 0, CardType.Victory));

            // Seaside
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

            // Alchemy
            this.Add(new Card(76, CardSet.Alchemy, "Transmute", 0, 1, CardType.Action));
            this.Add(new Card(77, CardSet.Alchemy, "Vinyard", 0, 1, CardType.Victory));

            this.Add(new Card(78, CardSet.Alchemy, "Apothecary", 2, 1, CardType.Action));
            this.Add(new Card(79, CardSet.Alchemy, "Herbalist", 2, 0, CardType.Action));
            this.Add(new Card(80, CardSet.Alchemy, "Scrying Pool", 2, 1, CardType.Attack));
            this.Add(new Card(81, CardSet.Alchemy, "University", 2, 1, CardType.Action));

            this.Add(new Card(82, CardSet.Alchemy, "Alchemist", 3, 1, CardType.Action));
            this.Add(new Card(83, CardSet.Alchemy, "Familiar", 3, 1, CardType.Attack));
            this.Add(new Card(84, CardSet.Alchemy, "Philosopher's Stone", 3, 1, CardType.Action));

            this.Add(new Card(85, CardSet.Alchemy, "Golem", 4, 1, CardType.Action));
            this.Add(new Card(86, CardSet.Alchemy, "Potion", 4, 0, CardType.Treasure));

            this.Add(new Card(87, CardSet.Alchemy, "Apprentice", 5, 0, CardType.Action));

            this.Add(new Card(88, CardSet.Alchemy, "Possesion", 6, 1, CardType.Action));

            // Prosperity
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

            // Promo Cards
            this.Add(new Card(1000, CardSet.Promo, "Black Market", 3, 0, CardType.Action));
            this.Add(new Card(2000, CardSet.Promo, "Envoy", 4, 0, CardType.Action));
            this.Add(new Card(3000, CardSet.Promo, "Stash", 5, 0, CardType.Treasure));
        }
    }
}