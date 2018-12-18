using Xunit;

namespace CourierKata.Tests
{
    public class WhenWorkingWithCourierKata
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
            var cost = parcel.CalculateCost();

            //Assert
            Assert.Equal(3, cost);
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
            var cost = parcel.CalculateCost();

            //Assert
            Assert.Equal(8, cost);
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
            var cost = parcel.CalculateCost();

            //Assert
            Assert.Equal(15, cost);
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
            var cost = parcel.CalculateCost();

            //Assert
            Assert.Equal(25, cost);
        }
    }
}
