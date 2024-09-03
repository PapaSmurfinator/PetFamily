namespace PetFamily.Domain.Models;

public sealed class Volunteer
{
    private readonly List<Requisites> _requisites = [];
    private readonly List<Pet> _pets = [];
    private readonly List<SocialNetwork> _socialNetworks = [];

    public Guid Id { get; private set; }
    public string FullName { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty;
    public int YearsOfExperience { get; private  set; } = 0;
    public int NumberOfPetsFindHome { get; private  set; } = 0;
    public int NumberOfPetsLookingHome { get; private  set; } = 0;
    public int NumberOfPetsBeingTreated { get; private  set; } = 0;
    public string PhoneNumber{ get; private set; } = string.Empty;
    public IReadOnlyList<SocialNetwork> SocialNetworks =>_socialNetworks;
    public IReadOnlyList<Requisites> Requisites => _requisites;
    public IReadOnlyList<Pet> Pets => _pets;
}