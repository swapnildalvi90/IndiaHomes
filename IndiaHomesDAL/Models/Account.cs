using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class Account
    {
        public Account()
        {
            this.Orders = new List<Order>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool LockedStatus { get; set; }
        public string EmailId { get; set; }
        public int NoOfAttempts { get; set; }
        public System.DateTime LockedTime { get; set; }
        public System.DateTime LastFailedLogin { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
