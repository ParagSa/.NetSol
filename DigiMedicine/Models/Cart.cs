namespace DigiMedicine.Models
{
    public class Cart
    {
        //ID	UserId	Discount	UnitPrice	Quantity	TotalPrice
        public int ID { get; set; }
        public int UserId { get; set; }
        public decimal Discount { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
