namespace DigiMedicine.Models
{
    public class Medicines
    {
        //ID	Name	Manufacturer	UnitPrice	Discount	Quantity	ExpDate	ImageUrl	Status

        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime DExpDate { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
    }
}
