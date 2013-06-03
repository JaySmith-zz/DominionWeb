using System.Collections.Generic;

namespace Dominionizer.Sets
{
    public class DarkAgesCards : List<Card>
    {
        public DarkAgesCards()
        {
            Initialize();
        }

        private void Initialize()
        {
            Add(new Card(801, CardSet.DarkAges, "Madman", 0, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Mercenary", 0, 0, CardType.Attack));
            Add(new Card(801, CardSet.DarkAges, "Poor House", 1, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Beggar", 2, 0, CardType.Reaction));
            Add(new Card(801, CardSet.DarkAges, "Squire", 2, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Vagrant", 2, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Forager", 3, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Hermit", 3, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Market Square", 3, 0, CardType.Reaction));
            Add(new Card(801, CardSet.DarkAges, "Sage", 3, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Storeroom", 3, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Urchin", 3, 0, CardType.Attack));
            Add(new Card(801, CardSet.DarkAges, "Armory", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Death Cart", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Fortress", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Ironmonger", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Marauder", 4, 0, CardType.Attack));
            Add(new Card(801, CardSet.DarkAges, "Procession", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Rats", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Scavenger", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Wandering Minstrel", 4, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Band of Misfits", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Bandit Camp", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Catacombs", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Count", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Cultist", 5, 0, CardType.Attack));
            Add(new Card(801, CardSet.DarkAges, "Graverobber", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Junk Dealer", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Mystic", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Pillage", 5, 0, CardType.Attack));
            Add(new Card(801, CardSet.DarkAges, "Rebuild", 5, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Rogue", 5, 0, CardType.Attack));
            Add(new Card(801, CardSet.DarkAges, "Altar", 6, 0, CardType.Action));
            Add(new Card(801, CardSet.DarkAges, "Hunting Grounds", 6, 0, CardType.Action));
        }
    }
}