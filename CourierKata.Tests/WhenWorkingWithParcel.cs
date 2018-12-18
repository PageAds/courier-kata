using Xunit;

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
            var parcel = new Parcel(dimensions, 1);

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
            var parcel = new Parcel(dimensions, 3);

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
            var parcel = new Parcel(dimensions, 6);

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
            var parcel = new Parcel(dimensions, 10);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(25, parcelCost.Cost);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(125)]
        [InlineData(150)]
        public void CalculateCost_HeavyParcel_50DollarsIsReturned(double dimensions)
        {
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void CalculateCost_SmallParcelWithSpeedyShipping_6DollarsIsReturned()
        {
            //Arrange
            var parcel = new Parcel(5, 1);

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
            var parcel = new Parcel(25, 3);

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
            var parcel = new Parcel(75, 6);

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
            var parcel = new Parcel(125, 10);

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(25, parcelCost.Cost);
            Assert.Equal(50, parcelCost.SpeedyShippingCost);
        }

        [Fact]
        public void CalculateCost_HeavyParcelWithSpeedyShipping_100DollarsIsReturned()
        {
            //Arrange

            //Act

            //Assert
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(2.5, 3)]
        [InlineData(4, 6)]
        public void CalculateCost_SmallParcelIsOverweight_OverweightChargeIsAddedToCostAndReturned(double weight, decimal overweightCharge)
        {
            //Arrange
            var parcel = new Parcel(5, weight);
            var smallParcelCost = 3;
            var expectedCost = smallParcelCost + overweightCharge;

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(expectedCost, parcelCost.Cost);
        }

        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 2)]
        [InlineData(4.5, 3)]
        [InlineData(6, 6)]
        public void CalculateCost_MediumParcelIsOverweight_OverweightChargeIsAddedToCostAndReturned(double weight, decimal overweightCharge)
        {
            //Arrange
            var parcel = new Parcel(25, weight);
            var mediumParcelCost = 8;
            var expectedCost = mediumParcelCost + overweightCharge;

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(expectedCost, parcelCost.Cost);
        }

        [Theory]
        [InlineData(6, 0)]
        [InlineData(7, 2)]
        [InlineData(7.5, 3)]
        [InlineData(9, 6)]
        public void CalculateCost_LargeParcelIsOverweight_OverweightChargeIsAddedToCostAndReturned(double weight, decimal overweightCharge)
        {
            //Arrange
            var parcel = new Parcel(75, weight);
            var largeParcelCost = 15;
            var expectedCost = largeParcelCost + overweightCharge;

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(expectedCost, parcelCost.Cost);
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(11, 2)]
        [InlineData(11.5, 3)]
        [InlineData(13, 6)]
        public void CalculateCost_XLParcelIsOverweight_OverweightChargeIsAddedToCostAndReturned(double weight, decimal overweightCharge)
        {
            //Arrange
            var parcel = new Parcel(125, weight);
            var xlParcelCost = 25;
            var expectedCost = xlParcelCost + overweightCharge;

            //Act
            var parcelCost = parcel.CalculateCost();

            //Assert
            Assert.Equal(expectedCost, parcelCost.Cost);
        }

        [Theory]
        [InlineData(50, 0)]
        [InlineData(51, 1)]
        [InlineData(51.5, 1.5)]
        [InlineData(53, 3)]
        public void CalculateCost_HeavyParcelIsOverweight_OverweightChargeIsAddedToCostAndReturned(double weight, decimal overweightCharge)
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
