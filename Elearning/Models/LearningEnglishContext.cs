﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ELearning.Models
{
    public partial class LearningEnglishContext : DbContext
    {
        public LearningEnglishContext()
        {
        }

        public LearningEnglishContext(DbContextOptions<LearningEnglishContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sentence> SentenceS { get; set; }
        public virtual DbSet<Vocabulary> VocabInModule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P8JJN5O;Initial Catalog=LearningEnglish;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .HasColumnName("contact_no");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("user_name");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Account__role_id__38996AB5");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Module1)
                    .IsRequired()
                    .HasColumnName("module");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.PartId).HasColumnName("part_id");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Module__level_id__403A8C7D");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.ModuleInPart)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Module__part_id__3F466844");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("Level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.Level1)
                    .IsRequired()
                    .HasColumnName("level");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("Part");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("part_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Sentence>(entity =>
            {
                entity.ToTable("Sentence");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModuleId).HasColumnName("Module_id");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("level");

                entity.HasOne(d => d.ModuleInSentence)
                    .WithMany(p => p.Sentences)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SentenceS__lesso__45F365D3");
            });

            modelBuilder.Entity<Vocabulary>(entity =>
            {
                entity.ToTable("Vocabulary");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.HasOne(d => d.ModuleInVocab)
                    .WithMany(p => p.VocabInModule)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VocabInLe__lesso__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}