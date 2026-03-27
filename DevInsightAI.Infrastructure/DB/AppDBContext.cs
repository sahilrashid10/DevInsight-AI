using Microsoft.EntityFrameworkCore;
using DevInsightAI.Domain.Entities.User;
using DevInsightAI.Domain.Entities.Rule;
using DevInsightAI.Domain.Entities.CodeSubmission;
using DevInsightAI.Domain.Entities.Violation;

namespace DevInsightAI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<CodeSubmission> CodeSubmissions { get; set; }
        public DbSet<Violation> Violations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relationships

            modelBuilder.Entity<CodeSubmission>()
                .HasMany(cs => cs.Violations)
                .WithOne(v => v.Submission)
                .HasForeignKey(v => v.SubmissionId);

            modelBuilder.Entity<Rule>()
                .HasMany(r => r.Violations)
                .WithOne(v => v.Rule)
                .HasForeignKey(v => v.RuleId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Submissions)
                .WithOne(cs => cs.User)
                .HasForeignKey(cs => cs.UserId);
        }
    }
}