using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Desenvolvedor_game>().HasKey(dg => new
            {
                dg.DesenvolvedorId,
                dg.gameId
            });
            modelBuilder.Entity<Desenvolvedor_game>().HasOne(g => g.Game).WithMany(dg => dg.Desenvolvedores_games).HasForeignKey(g => g.gameId);
            modelBuilder.Entity<Desenvolvedor_game>().HasOne(g => g.desenvolvedor).WithMany(dg => dg.Desenvolvedores_games).HasForeignKey(g => g.DesenvolvedorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<desenvolvedor> desenvolvedors { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Desenvolvedor_game> desenvolvedores_games { get; set; }
        public DbSet<Plataformas> Plataformas { get; set; }
        public DbSet<empressa> empressas { get; set; }
    }
}
