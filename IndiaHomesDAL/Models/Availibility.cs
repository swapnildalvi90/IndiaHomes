using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class Availibility
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
