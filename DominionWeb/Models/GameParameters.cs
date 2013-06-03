
namespace DominionWeb.Models
{
    using System.ComponentModel;

    public class GameParameters 
    {
        public bool Alchemy { get; set; }
        public bool Base { get; set; }
        public bool Cornucopia { get; set; }
        public bool DarkAges { get; set; }
        public bool Hinterlands { get; set; }
        public bool Intrigue { get; set; }
        public bool Prosperity { get; set; }
        public bool Seaside { get; set; }

        public bool Promo { get; set; }        

        [DisplayName("Require 2 to 5 cost cards")]
        public bool RequireTwoToFiveCostCards { get; set; }

        [DisplayName("Require reaction to attack")]
        public bool RequireReactionToAttack { get; set; }

        [DisplayName("Sort By")]
        public string SortBy { get; set; }
    }
}