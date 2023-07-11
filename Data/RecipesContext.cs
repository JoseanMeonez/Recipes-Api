using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Recipes_Api.Data;

public partial class RecipesContext : DbContext
{
  public RecipesContext()
  {
  }

  public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
  {
  }

  public virtual DbSet<Person> People { get; set; }

  public virtual DbSet<Recipe> Recipes { get; set; }

  /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
      => optionsBuilder.UseSqlServer("Server=DESKTOP-QMQ9BUD; Database=Recipes; Trusted_Connection=True; Encrypt=False;"); */

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Person>(entity =>
    {
      entity.Property(e => e.Id).HasColumnName("ID");
      entity.Property(e => e.LastName).HasMaxLength(50);
      entity.Property(e => e.Name).HasMaxLength(50);
    });

    modelBuilder.Entity<Recipe>(entity =>
    {
      entity.Property(e => e.Id).HasColumnName("ID");
      entity.Property(e => e.DateCreated)
        .HasColumnType("datetime")
        .HasColumnName("Date_Created");
      entity.Property(e => e.Description).HasMaxLength(255);
      entity.Property(e => e.PersonId).HasColumnName("Person_ID");
      entity.Property(e => e.Title).HasMaxLength(50);

      entity.HasOne(d => d.Person).WithMany(p => p.Recipes)
        .HasForeignKey(d => d.PersonId)
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Recipes_People");
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
