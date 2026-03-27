namespace DevInsightAI.Domain.Entities.Rule
{
    public class Rule
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Pattern { get; set; }
        public string? Severity { get; set; }
        public string? RuleType { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}