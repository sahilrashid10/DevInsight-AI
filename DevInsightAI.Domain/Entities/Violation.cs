namespace DevInsightAI.Domain.Entities.Violation
{
public class Violation
{
    public int Id { get; set; }

    public int SubmissionId { get; set; }
    public int RuleId { get; set; }

    public string Message { get; set; } = string.Empty;

    public int LineNumber { get; set; }

    public string CodeSnippet { get; set; } = string.Empty;

    // Navigation
    public CodeSubmission.CodeSubmission Submission { get; set; } = null!;
    public Rule.Rule Rule { get; set; } = null!;
}
}