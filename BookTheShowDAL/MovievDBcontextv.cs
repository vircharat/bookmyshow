using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookTheShowDAL
{
    public class MovieDBcontextv:DbContext
    {
        public DbSet<Moviev> moviesv { get; set; }
        public DbSet<Theatrev> theatresv { get; set; }
        public DbSet<ShowTimev> showtimingsv { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2179;Initial Catalog=BookTheShowv;Integrated Security=True;");
        }
    }
}
