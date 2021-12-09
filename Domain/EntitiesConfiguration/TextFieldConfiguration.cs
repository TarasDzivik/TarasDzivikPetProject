using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.EntitiesConfiguration
{
    public class TextFieldConfiguration : IEntityTypeConfiguration<TextField>
    {
        public void Configure(EntityTypeBuilder<TextField> builder)
        {
            //builder.HasKey(t => t.TextFieldId);

            builder.Property(t => t.TextFieldId)
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeWord)
                .IsRequired();

            builder.Property(t => t.Title)
                .HasColumnName("Назва сторінки (Заголовок)")
                .HasDefaultValue("Інформаційна сторінка");

            builder.Property(t => t.Text)
                .HasColumnName("Вміст сторінки") 
                .HasDefaultValue("Сторінка наповнюється Адміністратором");

            builder.HasData(
                new TextField
                {
                    Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                    CodeWord = "PageIndex",
                    Title = "Main"
                },
                new TextField
                {
                    Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                    CodeWord = "PageBuyVehicle",
                    Title = "Buy page"
                },
                new TextField
                {
                    Id = new Guid("70bf163a-700a-4156-91c0-e83fce0a277f"),
                    CodeWord = "PageRentVehicle",
                    Title = "Rent page"
                },
                new TextField 
                {
                    Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                    CodeWord = "PageLoanCalculator",
                    Title = "Loan Calculator"
                },
                new TextField
                {
                    Id = new Guid("4aa76b4c-c59d-409a-84c1-06e6487a137a"),
                    CodeWord = "PageContacts",
                    Title = "Contacts"
                });
        }
    }
}