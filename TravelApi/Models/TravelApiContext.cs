using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
//         protected override void OnModelCreating(ModelBuilder builder)
//         {
//             builder.Entity<Destination>()
//             .HasData(
//             new Destination { DestinationId = 1, City = "Portland", State = "OR", Country = "U S A", Review = 5 },
//             new Destination { DestinationId = 2, City = "Chicago", State = "IL", Country = "U S A", Review = 3 },
//             new Destination { DestinationId = 3, City = "Las Vegas", State = "Nevada",  Country = "U S A", Review = 2 },
//             new Destination { DestinationId = 4, City = "Miyami", State = "Florida",  Country = "U S A", Review = 4 },
//             new Destination { DestinationId = 5, City = "NewYork", State = "NewYourk", Country = "U S A", Review = 0 }
//         );
// }
    }
    
}