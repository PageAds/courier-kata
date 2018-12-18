namespace CourierKata
{
    public class ParcelCost
    {
        public decimal Cost { get; set; }

        public decimal SpeedyShippingCost { get { return this.Cost * 2; } }
    }
}
