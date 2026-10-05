using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Database.Maps;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");
        
        builder.HasKey(u => u.Id);
        
        builder.Property(u => u.Id)
            .HasColumnName("id").IsRequired();
        
        builder.Property(u => u.Name).IsRequired()
            .HasColumnName("name");
        
        builder.Property(u => u.Email).IsRequired()
            .HasColumnName("email");
        
        builder.Property(u => u.PasswordHash).IsRequired()
            .HasColumnName("password_hash");
        
        builder.Property(u => u.Status).IsRequired()
            .HasColumnName("status");
        
        builder.Property(u => u.CreatedAt).IsRequired()
            .HasColumnName("created_at");
        
        builder.Property(u => u.UpdatedAt).IsRequired()
            .HasColumnName("updated_at");
    }
}