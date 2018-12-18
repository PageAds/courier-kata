using System;

namespace CourierKata
{
    public class ParcelCost
    {
        private const double smallParcelWeightLimit = 1;
        private const double mediumParcelWeightLimit = 3;
        private const double largeParcelWeightLimit = 6;
        private const double xlParcelWeightLimit = 10;
        private const double heavyParcelWeightLimit = 50;

        private readonly decimal overweightCharge;
        private decimal cost;

        public ParcelCost(ParcelType parcelType, double weight)
        {
            this.cost = this.CalculateCostBasedOnParcelType(parcelType);
            this.overweightCharge = this.CalculateOverweightCharge(parcelType, weight);
        }

        public decimal Cost
        {
            get { return this.cost + this.overweightCharge; }
            set { this.cost = value; }
        }

        public decimal SpeedyShippingCost { get { return this.Cost * 2; } }

        private decimal CalculateCostBasedOnParcelType(ParcelType parcelType)
        {
            switch (parcelType)
            {
                case ParcelType.Small:
                    return 3;
                case ParcelType.Medium:
                    return 8;
                case ParcelType.Large:
                    return 15;
                case ParcelType.XL:
                    return 25;
                case ParcelType.Heavy:
                    return 50;
                default:
                    throw new Exception($"Unable to determine cost for Parcel Type: {parcelType}");
            }
        }

        private decimal CalculateOverweightCharge(ParcelType parcelType, double weight)
        {
            switch (parcelType)
            {
                case ParcelType.Small:
                    return weight > smallParcelWeightLimit
                        ? (decimal)(weight - smallParcelWeightLimit) * 2
                        : 0;
                case ParcelType.Medium:
                    return weight > mediumParcelWeightLimit
                        ? (decimal)(weight - mediumParcelWeightLimit) * 2
                        : 0;
                case ParcelType.Large:
                    return weight > largeParcelWeightLimit
                        ? (decimal)(weight - largeParcelWeightLimit) * 2
                        : 0;
                case ParcelType.XL:
                    return weight > xlParcelWeightLimit
                        ? (decimal)(weight - xlParcelWeightLimit) * 2
                        : 0;
                case ParcelType.Heavy:
                    return weight > heavyParcelWeightLimit
                        ? (decimal)(weight - heavyParcelWeightLimit) * 1
                        : 0;
                default:
                    throw new Exception($"Unable to determine overweight charge of Parcel Type: {parcelType}");
            }
        }
    }
}
