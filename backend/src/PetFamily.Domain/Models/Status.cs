namespace PetFamily.Domain.Models;

public sealed class Status
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty!;
}
