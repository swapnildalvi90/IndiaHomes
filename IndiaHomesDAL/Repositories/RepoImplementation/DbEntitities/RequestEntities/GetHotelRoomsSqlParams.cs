using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities
{
    public class GetHotelRoomsSqlParams
    {
        public int HotelId { get; set; }
        public DateTime ChekInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Guid SessionId { get; set; }
    }
}
