using Microsoft.EntityFrameworkCore;
using LifeGuides.Models;

public class ApplicationDBContext : DbContext
{
    public DbSet<User>? Users {get; set;} = null;
    public DbSet<Article>? Articles {get; set;} = null;
    public DbSet<Book>? Books {get; set;} = null;
    public DbSet<BooksAuthor>? BooksAuthors {get; set;} = null;
    public DbSet<TableTest>? TableTests {get; set;} = null;

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}