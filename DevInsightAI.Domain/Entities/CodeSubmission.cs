namespace DevInsightAI.Domain.Entities.CodeSubmission
{
    public class CodeSubmission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Code { get; set; }
        public double Score { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}