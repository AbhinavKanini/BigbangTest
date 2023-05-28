using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BigbangTest.Modules
{
    public class MyworldDbcontext : DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Room{ get; set; }
        public MyworldDbcontext(DbContextOptions<MyworldDbcontext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Room)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}