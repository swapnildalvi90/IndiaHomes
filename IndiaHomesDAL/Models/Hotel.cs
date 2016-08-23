using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            this.HotelRooms = new List<HotelRoom>();
        }

        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Ratings { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public Nullable<int> AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
