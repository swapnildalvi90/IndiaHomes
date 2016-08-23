using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class Address
    {
        public Address()
        {
            this.Hotels = new List<Hotel>();
        }

        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
