using RuleType = DevInsightAI.Domain.Enums.RuleType.RuleType;
using RuleSeverity = DevInsightAI.Domain.Enums.RuleSeverities.RuleSeverity;


namespace DevInsightAI.Domain.Entities.Rule
{
public class Rule
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Pattern { get; set; } = string.Empty;

    public RuleSeverity Severity { get; set; }

    public RuleType RuleType { get; set; }

    public bool IsActive { get; set; } = true;

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

    // Navigation
    public ICollection<Violation.Violation> Violations { get; set; }
        = new List<Violation.Violation>();
}
}