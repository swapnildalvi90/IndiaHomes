using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;
using IndiaHomesDAL.Repositories.RepoImplementation.SQLServerRepos;

namespace IndiaHomes.Database.UnitTests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void CreateOrder()
        {

            var sqlParams = new CreateOrderSqlParams()
            {
                //BookingNumber="121",
                CheckInDate = new DateTime(2016, 05, 29),
                CheckoutDate = new DateTime(2016, 05, 31),
                Cost = 123.44,
                Discount =1,
                EmailId = "sdalvi@tavisca.com",
                FirstName = "swapnil",
                LastName = "dalvi",
                MobileNumber = "123456",
                RoomId = 101,
                HotelId = 5,
                SessionId= System.Guid.NewGuid(),
                Status = "planned",
                Username = "sdalvi",
                
                
            };

            var Order = new OrderRepository().CreateOrder(sqlParams);
            
            //Assert.IsNotNull(Order);
            //Assert.IsTrue(hotels.Count > 0);
        }

        [TestMethod]
        public void GetOrders()
        {
            var sqlParams = new GetOrdersRequestSqlParams()
            {
                Username = "sdalvi",
                SessionId = new Guid()
            };

             new OrderRepository().GetOrdersForUser(sqlParams);
        }

        [TestMethod]
        public void GetOrder()
        {
            var sqlParams = new GetOrderRequestSqlParams()
            {
                FirstName = "swapnil",
                LastName = "dalvi",
                OrderId = 10005,
                SessionId = new Guid()
            };
            new OrderRepository().GetOrder(sqlParams);
        }
    }
}
