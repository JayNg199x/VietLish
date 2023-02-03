using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VietLish.Models.EF
{
    public partial class VietLishDbContext : DbContext
    {
        public VietLishDbContext()
            : base("name=VietLishDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<ScoreOfTest> ScoreOfTests { get; set; }
        public virtual DbSet<Sentence> Sentences { get; set; }
        public virtual DbSet<Study> Studies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Vocabulary> Vocabularies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Module>()
                .Property(e => e.topic_name)
                .IsUnicode(false);

            modelBuilder.Entity<Sentence>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.ScoreOfTests)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vocabulary>()
                .Property(e => e.image)
                .IsUnicode(false);
        }
    }
}
