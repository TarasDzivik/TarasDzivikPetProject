using System;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class ElementsBase
    {
        public Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string Text { get; set; }
        public virtual string TitleImagePath { get; set; }

        public DateTime DateAdded { get; set; }

        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
    }
}