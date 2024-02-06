using Microsoft.EntityFrameworkCore;
using RocketseatLeilao.API.Entities;

namespace RocketseatLeilao.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite("Data Source=C:\\dev\\rocketseat\\data-base\\leilaoDbNLW.db");

    }

}
