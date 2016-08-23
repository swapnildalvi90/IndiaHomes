using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.ResponseEntities
{
    public class OrderEntity
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
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string MobileNumber { get; set; } 
        public string EmailId { get; set; } 
        public string Street { get; set; }
        public string City { get; set; } 
        public string Region { get; set; } 
        public string Country { get; set; } 
        public string Code { get; set; } 
        public string Phone { get; set; } 
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string HotelImages { get; set; }
        public Nullable<int> Ratings { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string RoomDescription { get; set; }
        public string RoomImages { get; set; }
        public string RoomType { get; set; }
    }
}
