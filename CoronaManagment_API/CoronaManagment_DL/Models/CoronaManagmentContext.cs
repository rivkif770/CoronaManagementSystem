using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoronaManagment_DL.Models
{
    public partial class CoronaManagmentContext : DbContext
    {
        public CoronaManagmentContext()
        {
        }

        public CoronaManagmentContext(DbContextOptions<CoronaManagmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Sick> Sicks { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-056B5TE\\SQLEXPRESS;Database=corona;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.HasIndex(e => e.IdentityClient, "UQ__Client__2D476D818C77FF52")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);


                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sick>(entity =>
            {
                entity.ToTable("Sick");

                entity.HasIndex(e => e.IdClient, "UQ__Sick__C1961B32FA0A53D5")
                    .IsUnique();

                entity.Property(e => e.DatePositive).HasColumnType("date");

                entity.Property(e => e.DateRecovery).HasColumnType("date");

                entity.Property(e => e.IdClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClientNavigation)
                    .WithOne(p => p.Sick)
                    .HasPrincipalKey<Client>(p => p.IdentityClient)
                    .HasForeignKey<Sick>(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sick__IdClient__2B3F6F97");
            });

            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.ToTable("Vaccination");

                entity.Property(e => e.DateVaccin).HasColumnType("date");

                entity.Property(e => e.IdClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Vaccinations)
                    .HasPrincipalKey(p => p.IdentityClient)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vaccinati__NameC__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
