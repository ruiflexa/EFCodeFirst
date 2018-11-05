using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SE.EFCodeFirst.Infra.Data
{
    public partial class BancoAntigoContext : DbContext
    {
        public BancoAntigoContext()
        {
        }

        public BancoAntigoContext(DbContextOptions<BancoAntigoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbEndereco> TbEnderecoes { get; set; }
        public virtual DbSet<TbPessoa> TbPessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoAntigo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbEndereco>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndDsBairro).IsUnicode(false);

                entity.Property(e => e.EndDsLogradouro).IsUnicode(false);

                entity.Property(e => e.EndNrEndereco).IsUnicode(false);
            });

            modelBuilder.Entity<TbPessoa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PesNmPessoa).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
