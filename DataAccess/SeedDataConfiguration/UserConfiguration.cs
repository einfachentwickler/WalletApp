using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedDataConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        List<UserEntity> users = new()
        {
            new UserEntity
            {
                Id = 1,
                Name = "User 1"
            },
            new UserEntity
            {
                Id = 2,
                Name = "User 2"
            }
        };

        builder.HasData(users);
    }
}