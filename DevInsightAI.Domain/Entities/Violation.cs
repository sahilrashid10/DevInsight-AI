namespace DevInsightAI.Domain.Entities.Violation
{
    public class Violation
    {
        public int Id { get; set; }
        public int SubmissionId { get; set; }
        public int RuleId { get; set; }
        public string? Message { get; set; }
        public int LineNumber { get; set; }
        public string? CodeSnippet { get; set; }
    }
}