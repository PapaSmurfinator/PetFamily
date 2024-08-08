namespace PetFamily.Domain.Models;

public sealed class SocialNetwork
{
    public string Name { get; private set; } = string.Empty!;
    public string Url { get; private set; } = string.Empty!;
}
