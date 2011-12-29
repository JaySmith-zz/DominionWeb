namespace Dominionizer.Web.Models
{
    using System.Collections.Generic;

    using Dominionizer.Web.Core;

    public class IndexViewModel
    {
        public List<Card> Cards { get; set; }

        public GameParameters Parameters { get; set; }

        public string ValidationErrorMessage { get; set; }

        public bool IsValid()
        {
            // at least one set must be selected
            var trueCount = 0;
            
            if (Parameters.Alchemy) trueCount++;
            if (Parameters.Base) trueCount++;
            if (Parameters.Intrigue) trueCount++;
            if (Parameters.Prosperity) trueCount++;
            if (Parameters.Seaside) trueCount++;

            if (trueCount == 0 && Parameters.Promo)
            {
                ValidationErrorMessage = "Cannot play game of promo cards only, please select an additional set to go with them.";
                return false;
            }
            
            if (this.Parameters.Promo) trueCount++;

            if (trueCount == 0)
            {
                ValidationErrorMessage = "Please select one or more sets.";
                return false;
            }

            return true;

        }
    }
}