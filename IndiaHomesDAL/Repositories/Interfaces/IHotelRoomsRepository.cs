using IndiaHomesDAL.Models;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.Interfaces
{
    public interface IHotelRoomsRepository
    {
        List<HotelRoom> GetHotelRooms(GetHotelRoomsSqlParams sqlParams);
    }
}
