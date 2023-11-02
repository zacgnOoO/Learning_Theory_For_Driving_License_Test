using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.Models;

public partial class Swp391Context : DbContext
{
    public Swp391Context()
    {
    }

    public Swp391Context(DbContextOptions<Swp391Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionSampleTest> QuestionSampleTests { get; set; }

    public virtual DbSet<SampleTest> SampleTests { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentTest> StudentTests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= SWP391;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A2BF5AF7BE4");

            entity.ToTable("Category");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryType).HasMaxLength(50);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06F8C712D2EBC");

            entity.ToTable("Question");

            entity.Property(e => e.QuestionId)
                .ValueGeneratedNever()
                .HasColumnName("QuestionID");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .HasColumnName("CategoryID");
            entity.Property(e => e.ImageUrl)
                .IsUnicode(false)
                .HasColumnName("ImageURL");
            entity.Property(e => e.Question1).HasColumnName("Question");

            entity.HasOne(d => d.Category).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Question__Catego__398D8EEE");
        });

        modelBuilder.Entity<QuestionSampleTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QuestionSampleTest");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.SampleTestId)
                .HasMaxLength(10)
                .HasColumnName("SampleTestID");

            entity.HasOne(d => d.Question).WithMany()
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__QuestionS__Quest__440B1D61");

            entity.HasOne(d => d.SampleTest).WithMany()
                .HasForeignKey(d => d.SampleTestId)
                .HasConstraintName("FK__QuestionS__Sampl__44FF419A");
        });

        modelBuilder.Entity<SampleTest>(entity =>
        {
            entity.HasKey(e => e.SampleTestId).HasName("PK__SampleTe__644C4241BA72EA67");

            entity.ToTable("SampleTest");

            entity.Property(e => e.SampleTestId)
                .HasMaxLength(10)
                .HasColumnName("SampleTestID");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff__96D4AAF7FDF34504");

            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .HasColumnName("RoleID");
            entity.Property(e => e.StaffName).HasMaxLength(50);

            entity.HasOne(d => d.StaffNavigation).WithOne(p => p.Staff)
                .HasForeignKey<Staff>(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Staff__StaffID__45F365D3");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A794C512C15");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .HasMaxLength(50)
                .HasColumnName("StudentID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(10);
            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .HasColumnName("RoleID");
            entity.Property(e => e.StudentName).HasMaxLength(50);

            entity.HasOne(d => d.StudentNavigation).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student__Student__46E78A0C");
        });

        modelBuilder.Entity<StudentTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentTest");

            entity.Property(e => e.AnswerChoose)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.IsCorrect)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.SampleTestId)
                .HasMaxLength(10)
                .HasColumnName("SampleTestID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(50)
                .HasColumnName("StudentID");

            entity.HasOne(d => d.Question).WithMany()
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_StudentTest_Question");

            entity.HasOne(d => d.SampleTest).WithMany()
                .HasForeignKey(d => d.SampleTestId)
                .HasConstraintName("FK__StudentTe__Sampl__47DBAE45");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__StudentTe__Stude__48CFD27E");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACF949B5CC");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .HasColumnName("RoleID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
