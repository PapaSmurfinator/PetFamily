namespace PetFamily.Domain.Models;

public sealed class Pet
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty!;
    public string Type { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty;
    public string Breed { get; private set; }=string.Empty!;
    public string Color { get; private set; } = string.Empty;
    public string HelthInfo { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;
    public double Weight { get; private set; }
    public double Height { get; private set; }
    public string PhoneNumberOwner { get; private set; } = string.Empty;
    public bool IsCastrated { get; private set; } = false;
    public DateOnly Birthdate { get; private set; }
    public bool IsVaccinated { get; private set; } = false;
    public Status Status { get; private set; } = new();
    public Requisites Requisites { get; private set; } =new ();
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public List<PetPhoto> PetPhotos { get; private set; } = new();
}
