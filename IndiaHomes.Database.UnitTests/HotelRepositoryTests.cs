using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndiaHomesDAL.Repositories.RepoImplementation.SQLServerRepos;
using IndiaHomesDAL.Repositories.RepoImplementation.DbEntitities.RequestEntities;

namespace IndiaHomes.Database.UnitTests
{
    [TestClass]
    public class HotelRepositoryTests
    {
        private HotelRepository _hotelRepository = new HotelRepository();
        
        [TestMethod]
        public void GetHotels()
        {
            var sqlParams = new GetHotelsSqlParams()
                            {
                                Latitude = 9.578989983,
                                Longitude = 100.078872681,
                                SessionId = Guid.NewGuid()
                            };

           var hotels = _hotelRepository.GetHotels(sqlParams);

            Assert.IsNotNull(hotels);
            Assert.IsTrue(hotels.Count > 0);
        }
    }
}
