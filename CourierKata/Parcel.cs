﻿using System;

namespace CourierKata
{
    public class Parcel
    {
        private ParcelType parcelType;
        private readonly double weight;

        /// <summary>
        /// A parcel
        /// </summary>
        /// <param name="dimensions">Total size of all dimensions of the parcel in cm</param>
        /// <param name="weight">Weight of the parcel in kg</param>
        public Parcel(double dimensions, double weight)
        {
            this.parcelType = this.CalculateParcelType(dimensions);
            this.weight = weight;
        }

        public ParcelCost CalculateCost()
        {
            return new ParcelCost(parcelType, weight);
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
