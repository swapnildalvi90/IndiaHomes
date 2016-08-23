using IndiaHomesDAL.Models;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaHomesDAL.Repositories.Interfaces
{
    interface IOrderRepository
    {
        int CreateOrder(CreateOrderSqlParams sqlPaarms);
        int DeleteOrder(DeleteOrderSqlParams sqlParams);
        void GetOrder(GetOrderRequestSqlParams sqlParams);
        void GetOrdersForUser(GetOrdersRequestSqlParams sqlParams);
    }
}
