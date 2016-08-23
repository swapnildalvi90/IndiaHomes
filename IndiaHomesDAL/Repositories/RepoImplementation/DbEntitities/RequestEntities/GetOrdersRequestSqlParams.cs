using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities
{
    public class GetOrdersRequestSqlParams
    {
        public string Username { get; set; }
        public Guid SessionId { get; set; }
    }
}
