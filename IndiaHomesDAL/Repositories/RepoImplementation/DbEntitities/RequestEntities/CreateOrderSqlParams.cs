using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities
{
    public class CreateOrderSqlParams
    {
        //public string BookingNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public Double Cost { get; set; }
        public Double Discount { get; set; }
        public string Status { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public Guid SessionId { get; set; }

    }
}
