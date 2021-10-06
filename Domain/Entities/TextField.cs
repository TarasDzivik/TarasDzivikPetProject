using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Назва сторінки (заголовок)")]
        public override string Title { get; set; } = "Інформаційна сторінка";

        [Display(Name = "Контент сторінки")]
        public override string Text { get; set; } = "Контент додає Адміністратор";
    }
}
