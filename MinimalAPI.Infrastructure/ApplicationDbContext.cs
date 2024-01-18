using Microsoft.EntityFrameworkCore;
using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Infrastructure;

public class ApplicationDbContext
    (DbContextOptions<ApplicationDbContext> options) : DbContext
{
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<BookCategory> BooksCategories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=BookShop;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("MinimalAPI.Web"));
    }
}