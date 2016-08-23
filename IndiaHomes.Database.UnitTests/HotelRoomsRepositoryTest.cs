using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndiaHomesDAL.Repositories.RepoImplementation.SQLServerRepos;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;

namespace IndiaHomes.Database.UnitTests
{
    [TestClass]
    public class HotelRoomsRepositoryTest
    {
        [TestMethod]
        public void GetHotelRooms()
        {
            var sqlParams = new GetHotelRoomsSqlParams()
                            {
                                HotelId = 989,
                                ChekInDate = new DateTime(2016, 05, 28),
                                CheckOutDate = new DateTime(2016, 05, 30),
                                SessionId = new Guid()
                            };
            var hotelRooms = new HotelRoomsRepository().GetHotelRooms(sqlParams);
            Assert.IsNotNull(hotelRooms);
            Assert.IsTrue(hotelRooms.Count > 0);
        }
    }
}
