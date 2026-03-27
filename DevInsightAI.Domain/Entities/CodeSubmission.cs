namespace DevInsightAI.Domain.Entities.CodeSubmission
{
    public class CodeSubmission
    {
        public int Id { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Core Data
        public string Code { get; set; } = string.Empty;

        public decimal Score { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public User.User User { get; set; } = null!;

        public ICollection<Violation.Violation> Violations { get; set; } 
            = new List<Violation.Violation>();
    }
}