using System;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class TextField : ElementsBase
    {
        public Guid TextFieldId { get; set; }

        public string CodeWord { get; set; }
        public override string Title { get; set; }
        public override string Text { get; set; }
    }
}