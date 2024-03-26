using Microsoft.EntityFrameworkCore;

namespace RailwayTicketReservation.Models.Data
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Login> SignIn { get; set; }
        public DbSet<RegisterUser> UserRegistration { get; set; }
        public DbSet<Passenger> passengers { get; set; }
        public DbSet<ReserveTicket> ReserveTickets { get; set; }
        public DbSet<Schedule> trains { get; set; }






    }
}
