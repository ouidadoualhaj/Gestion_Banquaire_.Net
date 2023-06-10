using Microsoft.EntityFrameworkCore;

namespace GesBancaire.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
        }

        // Add DbSet properties for your entities
        // Example:
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Mouvement> Mouvements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mouvement>()
                .HasOne(m => m.Compte)
                .WithMany(c => c.Mouvements)
                .HasForeignKey(m => m.CompteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
