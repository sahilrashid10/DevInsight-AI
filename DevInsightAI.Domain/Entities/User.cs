using UserRole = DevInsightAI.Domain.Enums.UserRoles.UserRole;
namespace DevInsightAI.Domain.Entities.User
{
public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public ICollection<CodeSubmission.CodeSubmission> Submissions { get; set; }
        = new List<CodeSubmission.CodeSubmission>();
}
}