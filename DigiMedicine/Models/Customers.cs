using System;

namespace DigiMedicine.Models
{
    public class Customers
    {
        public int ID { set; get; }
        public string FirstName { set; get; }
        //LastName    Password Email   Fund Type    Status CreatedOn
        public string LastName { set; get; }
        public string Password { get; set; }

        public string Email { get; set; }

        public decimal Fund { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
