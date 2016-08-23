using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IndiaHomesDAL.Models.Mapping;
using IndiaHomesDAL.Models;
namespace IndiaHomesDAL.Repositories.Contexts
{
    public partial class IndiaHomesEFContext : DbContext
    {
        static IndiaHomesEFContext()
        {
            Database.SetInitializer<IndiaHomesEFContext>(null);
        }

        public IndiaHomesEFContext()
            : base("Name=IndiaHomesContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<AppException> AppExceptions { get; set; }
        public DbSet<Availibility> Availibilities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DBException> DBExceptions { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelAmenity> HotelAmenities { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AmenityMap());
            modelBuilder.Configurations.Add(new AppExceptionMap());
            modelBuilder.Configurations.Add(new AvailibilityMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DBExceptionMap());
            modelBuilder.Configurations.Add(new HotelMap());
            modelBuilder.Configurations.Add(new HotelAmenityMap());
            modelBuilder.Configurations.Add(new HotelRoomMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new PromoCodeMap());
        }
    }
}
