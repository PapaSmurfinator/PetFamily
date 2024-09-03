namespace PetFamily.Infrastructure.Data;

public sealed class PetFamilyDbContext(IConfiguration configuration): DbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Volunteer> Volunteers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            .UseSnakeCaseNamingConvention()
            .UseLoggerFactory(CreateLoggerFactory())
            .EnableSensitiveDataLogging();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    private ILoggerFactory CreateLoggerFactory() =>
        LoggerFactory.Create(builder => builder.AddConsole());
}