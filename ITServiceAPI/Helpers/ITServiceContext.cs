using Microsoft.EntityFrameworkCore;
using ITServiceModel.Models;
using ITServiceModel;

namespace ITServiceAPI.Helpers
{
    public partial class ITServiceContext : DbContext 
    {
        public ITServiceContext()
        {
        }

        public ITServiceContext(DbContextOptions<ITServiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserAccount> UserAccount { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=GF62\\SQLEXPRESS01;Database=ITService;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.EMP_ID);

            });
            

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
