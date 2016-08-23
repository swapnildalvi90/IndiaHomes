using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class Order
    {
        public long BookingNumber { get; set; }
        public int CustomerId { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public decimal Cost { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string Status { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Account Account { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
