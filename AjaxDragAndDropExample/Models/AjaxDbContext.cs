using Microsoft.EntityFrameworkCore;

namespace AjaxDragAndDropExample.Models
{
    public class AjaxDbContext : DbContext
    {

        public AjaxDbContext(DbContextOptions<AjaxDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<CustomerRoom> CustomerRooms { get; set; }

        public class DbInitializer
        {
            private readonly ModelBuilder modelBuilder;

            public DbInitializer(ModelBuilder modelBuilder)
            {
                this.modelBuilder = modelBuilder;
            }

            public void Seed()
            {
                modelBuilder.Entity<Customer>().HasData(
                        new Customer { Id = 1, FullName = "Mustafa DOĞAN" },
                        new Customer { Id = 2, FullName = "Ali DOĞAN" },
                        new Customer { Id = 3, FullName = "Abdullah DOĞAN" },
                        new Customer { Id = 4, FullName = "Rıza DOĞAN" },
                        new Customer { Id = 5, FullName = "Salih DOĞAN" },
                        new Customer { Id = 6, FullName = "Emre DOĞAN" },
                        new Customer { Id = 7, FullName = "Serhat DOĞAN" },
                        new Customer { Id = 8, FullName = "Fırat DOĞAN" },
                        new Customer { Id = 9, FullName = "Murat DOĞAN" });

                modelBuilder.Entity<RoomType>().HasData(
                    new RoomType { Id = 1, RoomTypeName = "Tekli Oda" },
                    new RoomType { Id = 2, RoomTypeName = "2'li Oda" },
                    new RoomType { Id = 3, RoomTypeName = "3'lü Oda" },
                    new RoomType { Id = 4, RoomTypeName = "4'lü Oda" }
                );

                modelBuilder.Entity<Room>().HasData(
                   new Room { Id = 1, RoomName = "101", RoomTypeID = 2 },
                   new Room { Id = 2, RoomName = "102", RoomTypeID = 3 },
                   new Room { Id = 3, RoomName = "103", RoomTypeID = 2 },
                   new Room { Id = 4, RoomName = "104", RoomTypeID = 4 });
            }
        }
    }
}
