using CDCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace CDCollection.Data;

public class CDCollectionContext : DbContext
{
    public CDCollectionContext(DbContextOptions<CDCollectionContext> options) : base(options)
    {
        
    }

    public DbSet<Album> Albums { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Rent> Rents { get; set; }
}