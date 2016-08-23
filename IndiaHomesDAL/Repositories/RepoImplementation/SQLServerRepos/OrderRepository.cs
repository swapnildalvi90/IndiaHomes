using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndiaHomesDAL.Repositories.Interfaces;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;
using IndiaHomesDAL.Repositories.Contexts;
using IndiaHomesDAL.Models;
using System.Data.SqlClient;
using System.Data;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.ResponseEntities;

namespace IndiaHomesDAL.Repositories.RepoImplementation.SQLServerRepos
{
    public class OrderRepository : IOrderRepository
    {
        public int CreateOrder(CreateOrderSqlParams sqlParams)
        {
            var isOrderGenerated = new SqlParameter();
            isOrderGenerated.ParameterName = "@StatusCode";
            isOrderGenerated.Direction = ParameterDirection.Output;
            isOrderGenerated.SqlDbType = SqlDbType.Int;
            using (var _context = new IndiaHomesEFContext())
            {
               
                try
                {
                    var a = 1;
                    var result = _context.Database.ExecuteSqlCommand("dbo.spCreateOrder @checkInDate, @checkOutDate, @cost, @discount, @status, @hotelId, @roomId, @username, @firstName, @lastName, @mobileNumber, @emailId, @sessId, @StatusCode OUT ",
                         new SqlParameter("@checkInDate", sqlParams.CheckInDate),
                         new SqlParameter("@checkOutDate", sqlParams.CheckoutDate),
                         new SqlParameter("@cost", sqlParams.Cost),
                         new SqlParameter("@discount", sqlParams.Discount),
                         new SqlParameter("@status", sqlParams.Status),
                         new SqlParameter("@hotelId", sqlParams.HotelId),
                         new SqlParameter("@roomId", sqlParams.RoomId),
                         new SqlParameter("@username", sqlParams.Username),
                         new SqlParameter("@firstName", sqlParams.FirstName),
                         new SqlParameter("@lastName", sqlParams.LastName),
                         new SqlParameter("@mobileNumber", sqlParams.MobileNumber),
                         new SqlParameter("@emailId", sqlParams.EmailId),
                         new SqlParameter("@sessId", sqlParams.SessionId),
                         isOrderGenerated);
                }
                catch(Exception)
                {
                    
                }
            }
            return Convert.ToInt32(isOrderGenerated.Value);
        }

        public int DeleteOrder(DeleteOrderSqlParams sqlParams)
        {
            var isOrderDeleted = new SqlParameter();
            isOrderDeleted.ParameterName = "@StatusCode";
            isOrderDeleted.Direction = ParameterDirection.Output;
            isOrderDeleted.SqlDbType = SqlDbType.Int;
            using (var _context = new IndiaHomesEFContext())
            {
                var result = _context.Database.ExecuteSqlCommand("dbo.spCancelBooking @orderId, @status, @firstName, @lastName,@sessId, @StatusCode OUT ",
                         new SqlParameter("@orderId", sqlParams.OrderId),
                         new SqlParameter("@status", sqlParams.Status),
                         new SqlParameter("@firstName", sqlParams.FirstName),
                         new SqlParameter("@lastName", sqlParams.LastName),
                         new SqlParameter("@sessId", sqlParams.SessionId),
                         isOrderDeleted);
            }

            return Convert.ToInt32(isOrderDeleted.Value);
        }

        public void GetOrder(GetOrderRequestSqlParams sqlParams)
        {
            using (var _context = new IndiaHomesEFContext())
            {
                var result = _context.Database.SqlQuery<OrderEntity>("dbo.spGetOrder {0}, {1}, {2}, {3}",
                    new Object[] { sqlParams.FirstName, sqlParams.LastName, sqlParams.OrderId, sqlParams.SessionId }).ToList();
                var b = result; 
                
            }
           
            //return new Order();
        }

        public void GetOrdersForUser(GetOrdersRequestSqlParams sqlParams)
        {
            using (var _context = new IndiaHomesEFContext())
            {
                var a = _context.Database.SqlQuery<OrderEntity>("dbo.spGetOrders {0}, {1}",
                    new Object[] { sqlParams.Username, sqlParams.SessionId}).ToList();
                var b = a;
            }
        }
    }
}
