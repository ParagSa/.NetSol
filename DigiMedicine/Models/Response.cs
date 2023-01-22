namespace DigiMedicine.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }
        public List<Customers> listCustomers { get; set; }

        public Customers customer { get; set; }

        public List<Medicines> listMedicines { get; set; }
        public Medicines medicine { get; set; }

        public List<Cart> listCart { get; set; }
        public Cart cart { get; set; }

        public List<Orders> listOrders { get; set; }
        public Orders order { get; set; }

        public List<OrderItems> listOrderItems { get; set; }
        public OrderItems orderitem { get; set; }
    }
}
