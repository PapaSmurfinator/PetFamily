namespace PetFamily.Domain.Models;

public sealed class Requisites
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty!;
}