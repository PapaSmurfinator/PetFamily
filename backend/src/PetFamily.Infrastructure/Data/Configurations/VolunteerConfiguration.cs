
namespace PetFamily.Infrastructure.Data.Configurations;

public sealed class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(b => b.Pets)
            .WithOne();
        builder.HasMany(b => b.Requisites)
            .WithOne();
        builder.HasMany(b => b.SocialNetworks)
            .WithOne();
    }
}
