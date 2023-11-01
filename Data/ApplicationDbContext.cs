using Microsoft.EntityFrameworkCore;


namespace assignments.Models

{

public class ApplicationDbContext : DbContext

{

public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

    {

    }

     // Change to be your model(s) and table(s)

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Product>()
        .HasKey(p => p.SKU);
}

public DbSet<Product> Products { get; set; }

public DbSet<Console> Consoles { get; set; }



}

}