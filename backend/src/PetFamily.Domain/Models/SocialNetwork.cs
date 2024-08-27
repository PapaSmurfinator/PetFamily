namespace PetFamily.Domain.Models;

public sealed class SocialNetwork
{
    public Guid Id { get; }
    public string Name { get; } = string.Empty!;
    public string Url { get; } = string.Empty!;
}
