namespace PetFamily.Domain.Models;

public sealed class Volunteer
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty;
    public int YearsOfExperience { get; private  set; } = 0;
    public int NumberOfPetsFindHome { get; private  set; } = 0;
    public int NumberOfPetsLookingHome { get; private  set; } = 0;
    public int NumberOfPetsBeingTreated { get; private  set; } = 0;
    public string PhoneNumber{ get; private set; } = string.Empty;
    public List<SocialNetwork> SocialNetworks { get; private set; } = new();
    public List<Requisites> Requisites { get; private set; } = new();
    public List<Pet> Pets { get; private set; } = new();
}