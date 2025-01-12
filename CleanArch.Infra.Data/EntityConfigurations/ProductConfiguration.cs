using System;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Price).HasPrecision(10, 2);

        builder.HasData(
            new Product
            {
                Id = 1,
                Name = "Caderno",
                Description = "Caderno Espiral 100 folhas",
                Price = 9.45m,
            },
            new Product
            {
                Id = 2,
                Name = "Lapis",
                Description = "Lapis 6B",
                Price = 0.5m,
            },
            new Product
            {
                Id = 3,
                Name = "Caneta",
                Description = "Caneta Azul",
                Price = 1.0m,
            }
        );
    }
}
