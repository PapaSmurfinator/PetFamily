namespace PetFamily.Domain.Models;

public sealed class Requisites
{
    public Guid Id { get;}
    public string Name { get;} = string.Empty!;
    public string Description { get;} = string.Empty!;
}