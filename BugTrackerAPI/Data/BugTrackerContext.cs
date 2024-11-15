using Microsoft.EntityFrameworkCore;

public class BugTrackerContext : DbContext
{
    public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Bug> Bugs { get; set; }
}
