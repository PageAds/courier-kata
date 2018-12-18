using System;

namespace CourierKata
{
    public class Parcel
    {
        private ParcelType parcelType;

        /// <summary>
        /// A parcel
        /// </summary>
        /// <param name="dimensions">Total size of all dimensions of the parcel in cm</param>
        public Parcel(double dimensions)
        {
            parcelType = this.CalculateParcelType(dimensions);
        }

        public decimal CalculateCost()
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
                default:
                    throw new Exception($"Unable to determine cost for Parcel Type: {parcelType}");

            }
        }

        private ParcelType CalculateParcelType(double dimensions)
        {
            if (dimensions < 10)
            {
                return ParcelType.Small;
            }

            if (dimensions < 50)
            {
                return ParcelType.Medium;
            }

            if (dimensions < 100)
            {
                return ParcelType.Large;
            }

            if (dimensions >= 100)
            {
                return ParcelType.XL;
            }

            throw new Exception($"Unable to determine Parcel Type based on dimensions: {dimensions}cm");
        }
    }
}
