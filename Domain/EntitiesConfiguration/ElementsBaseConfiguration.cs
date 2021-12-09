using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.EntitiesConfiguration
{
    public class ElementsBaseConfiguration : IEntityTypeConfiguration<ElementsBase>
    {
        public void Configure(EntityTypeBuilder<ElementsBase> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Title)
                .HasMaxLength(80)
                .HasColumnName("Заголовок")
                .IsUnicode(true);

            builder.Property(e => e.Title)
                .HasMaxLength(300)
                .HasColumnName("Короткий опис")
                .IsUnicode(true);

            builder.Property(e => e.TitleImagePath)
                .HasColumnName("Титульна картинка");

            builder.Property(e=>e.DateAdded)
                .ValueGeneratedOnAdd();


            builder.Property(e => e.MetaTitle)
                .HasColumnName("SEO Метатег Title");

            builder.Property(e => e.MetaDescription)
                .HasColumnName("SEO Метатег Description");

            builder.Property(e => e.MetaKeywords)
                .HasColumnName("SEO Метатег Keywords");
        }
    }
}