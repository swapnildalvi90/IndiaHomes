using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Username { get; set; }
        public string EmailId { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
