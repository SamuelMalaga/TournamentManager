using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize model
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Place to which the prize is associated
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Place name associated with the prize
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Quantity of prize
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Prize percentage, refer to the total prize quantity
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
