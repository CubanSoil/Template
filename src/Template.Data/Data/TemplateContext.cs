using Microsoft.EntityFrameworkCore;

namespace Template.Data.Data
{
  public class TemplateContext: DbContext
  {
    public TemplateContext()
    {
    }

    public TemplateContext(DbContextOptions<TemplateContext> options):base(options)
    {
    }

    public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<WeatherForecast>(entity =>
      {
        entity.HasKey(e => e.WeatherId);
        entity.ToTable("tb_Weather");
      });
    }
  }
}
