using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndiaHomesDAL.Repositories.Interfaces;
using IndiaHomesDAL.Repositories.Contexts;
using IndiaHomesDAL.Models;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;

namespace IndiaHomesDAL.Repositories.RepoImplementation.SQLServerRepos
{
    public class HotelRepository : IHotelRepository
    {
        public List<Hotel> GetHotels(GetHotelsSqlParams sqlParams)
        {
            using(var _context = new IndiaHomesEFContext())
            {
               var a =  _context.Database.SqlQuery<Hotel>("dbo.spGetHotels {0}, {1}, {2}, {3}, {4}",
                    new object[] { sqlParams.Latitude, sqlParams.Longitude,sqlParams.HotelName,sqlParams.StarRatings, sqlParams.SessionId}).ToList();
               return a;
            
            }
        }
            
    }
}
