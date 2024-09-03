namespace PetFamily.Infrastructure.Data.Configurations;

public sealed class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.HasKey(x => x.Id);


        builder.OwnsOne(b => b.Status);
        builder.HasMany(b => b.PetPhotos)
            .WithOne();
        builder.HasMany(b => b.Requisites)
            .WithOne();
    }
}
