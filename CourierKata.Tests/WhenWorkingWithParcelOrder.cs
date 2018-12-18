using System.Collections.Generic;
using Xunit;

namespace CourierKata.Tests
{
    public class WhenWorkingWithParcelOrder
    {
        [Fact]
        public void CalculateCost_WhenAnOrderIsApplicableForSmallParcelMania_Every4thSmallParcelIsFreeAndCostIsReturned()
        {
            //Arrange
            var parcels = new List<Parcel>()
            {
                new Parcel(5, 1), //$3
                new Parcel(5, 2), //$5
                new Parcel(5, 1), //$3
                new Parcel(5, 2), //$3
            };

            var parcelOrder = new ParcelOrder(parcels);

            //Act
            var parcelCost = parcelOrder.CalculateCost();

            //Assert
            Assert.Equal(14, parcelCost.Cost);
            Assert.Equal(-3, parcelCost.Discount);
        }

        [Fact]
        public void CalculateCost_WhenAnOrderIsApplicableForMediumParcelMania_Every3rdMediumParcelIsFreeAndCostIsReturned()
        {
            //Arrange
            var parcels = new List<Parcel>()
            {
                new Parcel(25, 3), //$8
                new Parcel(25, 4), //$10
                new Parcel(25, 3)  //$8
            };

            var parcelOrder = new ParcelOrder(parcels);

            //Act
            var parcelCost = parcelOrder.CalculateCost();

            //Assert
            Assert.Equal(26, parcelCost.Cost);
            Assert.Equal(-8, parcelCost.Discount);
        }

        [Fact]
        public void CalculateCost_WhenAnOrderIsApplicableForMixedParcelMania_Every5thParcelIsFreeAndCostIsReturned()
        {
            //Arrange
            var parcels = new List<Parcel>()
            {
                new Parcel(5, 1),  //$3
                new Parcel(25, 3), //$8
                new Parcel(75, 6), //$15
                new Parcel(5, 1),  //$3
                new Parcel(25, 3)  //$8  
            };

            var parcelOrder = new ParcelOrder(parcels);

            //Act
            var parcelCost = parcelOrder.CalculateCost();

            //Assert
            Assert.Equal(37, parcelCost.Cost);
            Assert.Equal(-3, parcelCost.Discount);
        }

        [Fact]
        public void CalculateCost_WhenAnOrderIsApplicableForMultipleDiscounts_BestPriceDiscountsAreSelectedAndCostIsReturned()
        {
            //Arrange
            var parcels = new List<Parcel>()
            {
                new Parcel(5, 1),  //$3
                new Parcel(5, 1),  //$3  
                new Parcel(5, 1),  //$3
                new Parcel(5, 1),  //$3
                new Parcel(25, 3), //$8
                new Parcel(25, 3), //$8
                new Parcel(25, 3)  //$8
            };

            var parcelOrder = new ParcelOrder(parcels);

            //Act
            var parcelCost = parcelOrder.CalculateCost();

            //Assert
            Assert.Equal(36, parcelCost.Cost);
            Assert.Equal(-11, parcelCost.Discount);
        }
    }
}
