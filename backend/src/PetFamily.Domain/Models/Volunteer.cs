namespace PetFamily.Domain.Models;

public sealed class Volunteer
{
    public Guid Id { get; private set; }
    public string FIO { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty;
    public byte YearsOfExperience { get; set; } = 0;
    public uint NumberOfPets { get; set; } = 0;
    public string PhoneNumber{ get; private set; } = string.Empty;
    public List<SocialNetwork> SocialNetworks { get; set; } = new();
    public Requisites Requisites { get; private set; } = new();
}