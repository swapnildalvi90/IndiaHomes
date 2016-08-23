using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndiaHomesDAL.Repositories.Interfaces;
using IndiaHomesDAL.Models;
using IndiaHomesDAL.Repositories.Contexts;

namespace IndiaHomesDAL.Repositories.RepoImplementation.SQLServerRepos
{
    public class HotelRoomsRepository : IHotelRoomsRepository
    {
        public List<HotelRoom> GetHotelRooms(DbEntitities.RequestEntities.GetHotelRoomsSqlParams sqlParams)
        {
            using (var _context = new IndiaHomesEFContext())
            {
                return _context.Database.SqlQuery<HotelRoom>("dbo.spGetHotelRooms {0}, {1}, {2}, {3}",
                    new object[] { sqlParams.HotelId, sqlParams.ChekInDate, sqlParams.CheckOutDate, sqlParams.SessionId}).ToList();
            }
        }
    }
}
