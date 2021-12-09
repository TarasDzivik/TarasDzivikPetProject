using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.EntitiesConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.FirstName)
                .HasMaxLength(20)
                .HasColumnName("Ім'я")
                .IsUnicode(true)
                .IsRequired();

            builder.Property(c => c.LustName)
                .HasMaxLength(20)
                .HasColumnName("Прізвище")
                .IsUnicode(true)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(c => c.Phone)
                .HasMaxLength(17)
                .IsRequired();

            // можливо треба буде зробити зв'язок клієнта
            // з авто і якесь підтвердження релевантності
        }
    }
}