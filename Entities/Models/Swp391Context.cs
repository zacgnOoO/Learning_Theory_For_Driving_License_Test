using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

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

    public virtual DbSet<SampleTest> SampleTests { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentTest> StudentTests { get; set; }

    public virtual DbSet<TestAnswer> TestAnswers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= SWP391;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A2B7CA57788");

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
                .HasMaxLength(50)
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

        modelBuilder.Entity<SampleTest>(entity =>
        {
            entity.HasKey(e => e.SampleTestId).HasName("PK__SampleTe__644C42415DBCC3F3");

            entity.ToTable("SampleTest");

            entity.Property(e => e.SampleTestId)
                .HasMaxLength(10)
                .HasColumnName("SampleTestID");
            entity.Property(e => e.QuestionId)
                .HasMaxLength(50)
                .HasColumnName("QuestionID");

            entity.HasOne(d => d.Question).WithMany(p => p.SampleTests)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__SampleTes__Quest__440B1D61");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK__Session__C9F49270446B99BB");

            entity.ToTable("Session");

            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .HasColumnName("SessionID");
            entity.Property(e => e.Day).HasColumnType("date");
            entity.Property(e => e.ScheduleId)
                .HasMaxLength(50)
                .HasColumnName("ScheduleID");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff__96D4AAF7698C57D6");

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
                .HasConstraintName("FK__Staff__StaffID__49C3F6B7");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A79C1F76B6D");

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
                .HasConstraintName("FK__Student__Student__4AB81AF0");
        });

        modelBuilder.Entity<StudentTest>(entity =>
        {
            entity.HasKey(e => e.SampleTestId).HasName("PK__StudentT__644C4241DF6D85C3");

            entity.ToTable("StudentTest");

            entity.Property(e => e.SampleTestId)
                .HasMaxLength(10)
                .HasColumnName("SampleTestID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(50)
                .HasColumnName("StudentID");
            entity.Property(e => e.TestAnswerId)
                .HasMaxLength(50)
                .HasColumnName("TestAnswerID");

            entity.HasOne(d => d.SampleTest).WithOne(p => p.StudentTest)
                .HasForeignKey<StudentTest>(d => d.SampleTestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentTe__Sampl__4BAC3F29");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentTests)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__StudentTe__Stude__4CA06362");

            entity.HasOne(d => d.TestAnswer).WithMany(p => p.StudentTests)
                .HasForeignKey(d => d.TestAnswerId)
                .HasConstraintName("FK__StudentTe__TestA__4D94879B");
        });

        modelBuilder.Entity<TestAnswer>(entity =>
        {
            entity.HasKey(e => e.TestAnswerId).HasName("PK__TestAnsw__0B8662895A22383B");

            entity.ToTable("TestAnswer");

            entity.Property(e => e.TestAnswerId)
                .HasMaxLength(50)
                .HasColumnName("TestAnswerID");
            entity.Property(e => e.CorrectAnswer).HasColumnType("text");
            entity.Property(e => e.QuestionId)
                .HasMaxLength(50)
                .HasColumnName("QuestionID");

            entity.HasOne(d => d.Question).WithMany(p => p.TestAnswers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__TestAnswe__Quest__3C69FB99");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC8707C3DD");

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
