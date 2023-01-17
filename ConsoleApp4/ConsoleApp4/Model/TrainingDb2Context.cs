using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp4.Model;

public partial class TrainingDb2Context : DbContext
{
    public TrainingDb2Context()
    {
    }

    public TrainingDb2Context(DbContextOptions<TrainingDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Author1> Author1s { get; set; }

    public virtual DbSet<Book1> Book1s { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentGrade> StudentGrades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=10.10.10.8\\ISG_MSSQLSERVER;initial catalog=TrainingDB2;user id=sa;password=pq+V2%g5gN!7;MultipleActiveResultSets=True;Persist Security Info=True;Integrated Security=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author1>(entity =>
        {
            entity.ToTable("Author1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedDate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(512);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
        });

        modelBuilder.Entity<Book1>(entity =>
        {
            entity.ToTable("Book1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedDate).HasColumnType("date");
            entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Publisher).HasMaxLength(512);

            entity.HasOne(d => d.Author).WithMany(p => p.Book1s)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book1_Author1");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Address)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentGrade>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId);

            entity.ToTable("StudentGrade");

            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Grade).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
