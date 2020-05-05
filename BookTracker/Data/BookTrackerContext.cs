using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookTracker.Data
{
    public partial class BookTrackerContext : DbContext
    {
        public BookTrackerContext()
        {
        }

        public BookTrackerContext(DbContextOptions<BookTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=Captain8;database=booktracker", x => x.ServerVersion("10.4.12-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.Authorid)
                    .HasColumnName("authorid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PRIMARY");

                entity.ToTable("book");

                entity.HasIndex(e => e.Authorid)
                    .HasName("book_fk_authorid");

                entity.HasIndex(e => e.Genre)
                    .HasName("book_fk_genre");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Authorid)
                    .HasColumnName("authorid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasColumnName("genre")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.Book)
                    .HasPrincipalKey(p => p.Type)
                    .HasForeignKey(d => d.Genre)
                    .HasConstraintName("book_fk_genre");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.HasIndex(e => e.Type)
                    .HasName("Index 2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
