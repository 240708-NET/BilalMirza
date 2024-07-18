using Microsoft.EntityFrameworkCore;
namespace MigrationDemoWeb.Models;

public class DemoContext : DbContext
{
    public DemoContext(DbContextOptions<DemoContext> options) : base(options);
    public DbSet<Employee> employee { get; set; }
    public DbSet<Departments> departments { get; set; }

}