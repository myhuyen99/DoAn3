using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DoAn3.Models
{
    public partial class acomptec_dulichTHContext : DbContext
    {
        public acomptec_dulichTHContext()
        {
        }

        public acomptec_dulichTHContext(DbContextOptions<acomptec_dulichTHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baidanhgia> Baidanhgia { get; set; }
        public virtual DbSet<Baivietdulich> Baivietdulich { get; set; }
        public virtual DbSet<Diadiemdulich> Diadiemdulich { get; set; }
        public virtual DbSet<Hinhanh> Hinhanh { get; set; }
        public virtual DbSet<Quantri> Quantri { get; set; }
        public virtual DbSet<Taikhoan> Taikhoan { get; set; }
        public virtual DbSet<Tinhthanh> Tinhthanh { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=210.245.90.239;Database=acomptec_dulichTH;User Id=acomptec_group11719;Password=group@11719");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "acomptec_group11719");

            modelBuilder.Entity<Baidanhgia>(entity =>
            {
                entity.HasKey(e => e.BdgMa)
                    .HasName("PK__BAIDANHG__E1530771E59718D6");

                entity.ToTable("BAIDANHGIA");

                entity.Property(e => e.BdgMa)
                    .HasColumnName("BDG_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BdgLuotthich).HasColumnName("BDG_LUOTTHICH");

                entity.Property(e => e.BdgNoidung)
                    .HasColumnName("BDG_NOIDUNG")
                    .HasMaxLength(1000);

                entity.Property(e => e.BdgTk)
                    .HasColumnName("BDG_TK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BdgTkNavigation)
                    .WithMany(p => p.Baidanhgia)
                    .HasForeignKey(d => d.BdgTk)
                    .HasConstraintName("FK__BAIDANHGI__BDG_T__58D1301D");
            });

            modelBuilder.Entity<Baivietdulich>(entity =>
            {
                entity.HasKey(e => e.BvdlMa)
                    .HasName("PK__BAIVIETD__15B372EF46E156CD");

                entity.ToTable("BAIVIETDULICH");

                entity.Property(e => e.BvdlMa)
                    .HasColumnName("BVDL_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BvdlLuotthich).HasColumnName("BVDL_LUOTTHICH");

                entity.Property(e => e.BvdlMabdg)
                    .HasColumnName("BVDL_MABDG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BvdlMadddl)
                    .HasColumnName("BVDL_MADDDL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BvdlMahinhanh)
                    .HasColumnName("BVDL_MAHINHANH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BvdlMaqt)
                    .HasColumnName("BVDL_MAQT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BvdlMatt)
                    .HasColumnName("BVDL_MATT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BvdlNoidung)
                    .HasColumnName("BVDL_NOIDUNG")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.BvdlMabdgNavigation)
                    .WithMany(p => p.Baivietdulich)
                    .HasForeignKey(d => d.BvdlMabdg)
                    .HasConstraintName("FK__BAIVIETDU__BVDL___5F7E2DAC");

                entity.HasOne(d => d.BvdlMadddlNavigation)
                    .WithMany(p => p.Baivietdulich)
                    .HasForeignKey(d => d.BvdlMadddl)
                    .HasConstraintName("FK__BAIVIETDU__BVDL___5CA1C101");

                entity.HasOne(d => d.BvdlMahinhanhNavigation)
                    .WithMany(p => p.Baivietdulich)
                    .HasForeignKey(d => d.BvdlMahinhanh)
                    .HasConstraintName("FK__BAIVIETDU__BVDL___5E8A0973");

                entity.HasOne(d => d.BvdlMaqtNavigation)
                    .WithMany(p => p.Baivietdulich)
                    .HasForeignKey(d => d.BvdlMaqt)
                    .HasConstraintName("FK__BAIVIETDU__BVDL___5BAD9CC8");

                entity.HasOne(d => d.BvdlMattNavigation)
                    .WithMany(p => p.Baivietdulich)
                    .HasForeignKey(d => d.BvdlMatt)
                    .HasConstraintName("FK__BAIVIETDU__BVDL___5D95E53A");
            });

            modelBuilder.Entity<Diadiemdulich>(entity =>
            {
                entity.HasKey(e => e.DddlMa)
                    .HasName("PK__DIADIEMD__1E9D3A78A52496A7");

                entity.ToTable("DIADIEMDULICH");

                entity.Property(e => e.DddlMa)
                    .HasColumnName("DDDL_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DddlTen)
                    .HasColumnName("DDDL_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.HasKey(e => e.HaMa)
                    .HasName("PK__HINHANH__BE83C5BD2729ACA1");

                entity.ToTable("HINHANH");

                entity.Property(e => e.HaMa)
                    .HasColumnName("HA_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaTen)
                    .HasColumnName("HA_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.HaUrl)
                    .HasColumnName("HA_URL")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Quantri>(entity =>
            {
                entity.HasKey(e => e.QtMa)
                    .HasName("PK__QUANTRI__0754A321277E15E1");

                entity.ToTable("QUANTRI");

                entity.Property(e => e.QtMa)
                    .HasColumnName("QT_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtEmail)
                    .HasColumnName("QT_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtMatkhau)
                    .HasColumnName("QT_MATKHAU")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.TkMa)
                    .HasName("PK__TAIKHOAN__641689968F74C0DA");

                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.TkMa)
                    .HasColumnName("TK_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TkEmail)
                    .HasColumnName("TK_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TkHoten)
                    .HasColumnName("TK_HOTEN")
                    .HasMaxLength(50);

                entity.Property(e => e.TkMatkhau)
                    .HasColumnName("TK_MATKHAU")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tinhthanh>(entity =>
            {
                entity.HasKey(e => e.TtMa)
                    .HasName("PK__TINHTHAN__E9D6621F8FD04BF9");

                entity.ToTable("TINHTHANH");

                entity.Property(e => e.TtMa)
                    .HasColumnName("TT_MA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TtTen)
                    .HasColumnName("TT_TEN")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
