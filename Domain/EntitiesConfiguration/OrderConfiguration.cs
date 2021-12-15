//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using TarasDzivikPetProject.Domain.Entities;

//namespace TarasDzivikPetProject.Domain.EntitiesConfiguration
//{
//    public class OrderConfiguration : IEntityTypeConfiguration<Order>
//    {
//        public void Configure(EntityTypeBuilder<Order> builder)
//        {
//            builder.HasKey(o => o.OrderId);

//            builder.Property(o => o.FirstName)
//               .HasMaxLength(20)
//               .HasColumnName("Ім'я")
//               .IsUnicode(true)
//               .IsRequired();

//            builder.Property(o => o.LustName)
//                .HasMaxLength(20)
//                .HasColumnName("Прізвище")
//                .IsUnicode(true)
//                .IsRequired();

//            builder.Property(o => o.Email)
//               .HasMaxLength(40)
//               .IsRequired();

//            builder.Property(o => o.Phone)
//                .HasMaxLength(17)
//                .IsRequired();

//            builder.Property(o => o.OrderId)
//                .ValueGeneratedOnAdd();

//            builder.Property(o => o.Accepted)
//                .HasColumnName("Статус замовлення");

//            builder.Property(o => o.OrderTime)
//                .ValueGeneratedOnAdd();

//            builder.HasMany(o => o.Vehicle)
//                .WithOne(o => o.Order)
//                .HasForeignKey(c => c.VehicleId)
//                .OnDelete(DeleteBehavior.Cascade);
//        }
//    }
//}