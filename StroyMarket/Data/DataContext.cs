using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StroyMarket.Enums;
using StroyMarket.Model;

namespace StroyMarket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=tiny.db.elephantsql.com;Database=hbbvqrol;Username=hbbvqrol;Password=8UxRew7pJC38TkqJ9_ZyNpT09qhfsKBP");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.user_id);
                entity.Property(e => e.first_name).HasMaxLength(30).IsRequired();
                entity.Property(e => e.last_name).HasMaxLength(30).IsRequired();
                entity.Property(e => e.phone).HasMaxLength(12).IsRequired();
                entity.Property(e => e.password).IsRequired();
                entity.Property(e => e.role).IsRequired();
                entity.Property(e => e.verified).HasDefaultValue(false);
                entity.Property(e => e.verification_code).IsRequired(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");
                entity.HasKey(e => e.id);
                entity.Property(e => e.name_uz).HasMaxLength(30).IsRequired();
                entity.Property(e => e.name_ru).HasMaxLength(30).IsRequired();
                entity.Property(e => e.description).HasMaxLength(30).IsRequired(false);
                entity.Property(e => e.created_at).HasDefaultValue<DateTime>(new DateTime());
                entity.Property(e => e.deleted_at).HasDefaultValue<DateTime>(new DateTime());
            });
        }
    }

}
