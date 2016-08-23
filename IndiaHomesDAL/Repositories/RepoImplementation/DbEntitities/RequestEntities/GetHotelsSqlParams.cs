using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities
{
    public class GetHotelsSqlParams
    {
       public double Latitude { get; set; }
       public double Longitude { get; set; }
       public string HotelName { get; set; }
       public int StarRatings { get; set; }
       public Guid SessionId { get; set; }
    }
}
