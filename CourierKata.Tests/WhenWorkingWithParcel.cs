﻿using Xunit;

namespace CourierKata.Tests
{
    public class WhenWorkingWithParcel
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(9)]
        public void CalculateCost_SmallParcel_3DollarsIsReturned(double dimensions)
        {
            //Arrange
            var parcel = new Parcel(dimensions);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(3, parcelCost.Cost);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(49)]
        public void CalculateCost_MediumParcel_8DollarsIsReturned(double dimensions)
        {
            //Arrange
            var parcel = new Parcel(dimensions);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(8, parcelCost.Cost);
        }

        [Theory]
        [InlineData(50)]
        [InlineData(75)]
        [InlineData(99)]
        public void CalculateCost_LargeParcel_15DollarsIsReturned(double dimensions)
        {
            //Arrange
            var parcel = new Parcel(dimensions);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(15, parcelCost.Cost);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(125)]
        [InlineData(150)]
        public void CalculateCost_XLParcel_25DollarsIsReturned(double dimensions)
        {
            //Arrange
            var parcel = new Parcel(dimensions);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(25, parcelCost.Cost);
        }

        [Fact]
        public void CalculateCost_SmallParcelWithSpeedyShipping_6DollarsIsReturned()
        {
            //Arrange
            var parcel = new Parcel(5);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(3, parcelCost.Cost);
            Assert.Equal(6, parcelCost.SpeedyShippingCost);
        }

        [Fact]
        public void CalculateCost_MediumParcelWithSpeedyShipping_16DollarsIsReturned()
        {
            //Arrange
            var parcel = new Parcel(25);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(8, parcelCost.Cost);
            Assert.Equal(16, parcelCost.SpeedyShippingCost);
        }

        [Fact]
        public void CalculateCost_LargeParcelWithSpeedyShipping_30DollarsIsReturned()
        {
            //Arrange
            var parcel = new Parcel(75);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(15, parcelCost.Cost);
            Assert.Equal(30, parcelCost.SpeedyShippingCost);
        }

        [Fact]
        public void CalculateCost_XLParcelWithSpeedyShipping_50DollarsIsReturned()
        {
            //Arrange
            var parcel = new Parcel(125);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(25, parcelCost.Cost);
            Assert.Equal(50, parcelCost.SpeedyShippingCost);
        }
    }
}