using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.EntitiesConfiguration
{
    public class VehicleItemConfiguration : IEntityTypeConfiguration<VehicleItem>
    {
        public void Configure(EntityTypeBuilder<VehicleItem> builder)
        {
            builder.HasKey(v => v.VehicleId);

            builder.Property(v=>v.VehicleId)
                .ValueGeneratedOnAdd();

            builder.Property(v => v.TitleImagePath)
                .HasColumnName("Url Картинки");
           
            builder.Property(v=>v.vehicleType)
                .HasColumnName("Тип транспортного засобу")
                .HasConversion<string>();

            builder.Property(v => v.Fuel)
                .HasColumnName("Вид палива")
                .HasConversion<string>();

            builder.Property(v => v.Description)
                .HasColumnName("Опис авто")
                .IsRequired();

            builder.Property(v => v.Title)
                .HasMaxLength(80)
                .HasColumnName("Заголовок")
                .IsRequired();

            builder.Property(v => v.Name)
                .HasMaxLength(30)
                .HasColumnName("Марка Авто")
                .IsRequired();

            builder.Property(v => v.Travelled)
                .HasMaxLength(7)
                .HasColumnName("Пробіг")
                .IsRequired();

            builder.Property(v => v.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Ціна в $")
                .IsRequired();

            builder.Property(v => v.DateAdded)
                .HasColumnName("Додано")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(v => v.MetaTitle)
                .HasColumnName("SEO Метатег Title");

            builder.Property(v => v.MetaDescription)
                .HasColumnName("SEO Метатег Description");

            builder.Property(v => v.MetaKaywords)
                .HasColumnName("SEO Метатег Keywords");
        }
    }
}