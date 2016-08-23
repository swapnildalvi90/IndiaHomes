using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class HotelRoom
    {
        public HotelRoom()
        {
            this.Availibilities = new List<Availibility>();
            this.Orders = new List<Order>();
        }

        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string TypeName { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Availibility> Availibilities { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
