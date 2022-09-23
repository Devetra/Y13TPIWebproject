using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Y13TPIWebproject.Areas.Identity.Data;
using Y13TPIWebproject.Models;

namespace Y13TPIWebproject.Areas.Identity.Data;

public class Y13TPIWebprojectContextDB : IdentityDbContext<Y13TPIWebprojectUser>
{
    public Y13TPIWebprojectContextDB(DbContextOptions<Y13TPIWebprojectContextDB> options)
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

    public DbSet<Y13TPIWebproject.Models.Product>? Product { get; set; }

  



    public DbSet<Y13TPIWebproject.Models.Customer>? Customer { get; set; }

  



    public DbSet<Y13TPIWebproject.Models.Order> Order { get; set; }


}
