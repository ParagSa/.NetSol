namespace DigiMedicine.Models
{
    public class Orders
    {
        //ID	UserId	OrderNo	OrderTotal	OrderStatus

        public int ID { get; set; }
        public int UserId { get; set; }
        public string OrderNo { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderStatus { get; set; }

    }
}
