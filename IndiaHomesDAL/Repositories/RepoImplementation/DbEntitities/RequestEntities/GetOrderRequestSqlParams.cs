using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities
{
    public class GetOrderRequestSqlParams
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrderId { get; set; }
        public Guid SessionId { get; set; }
    }
}
