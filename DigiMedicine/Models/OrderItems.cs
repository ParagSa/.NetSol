namespace DigiMedicine.Models
{
    public class OrderItems
    {
        //ID	OrderId	MedicineID	UnitPrice	Discount	Quantity	TotalPrice

        public int ID { get; set; }
        public int OrderId { get; set; }
        public int MedicineID { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
