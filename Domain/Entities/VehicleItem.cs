using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarasDzivikPetProject.Domain.Entities
{
    public class VehicleItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву транспортного засобу")]
        [Display(Name = "Назва транспортного засобу")]
        public override string Title { get; set; }

        [Required(ErrorMessage = "Вкажіть ціну транспортного засобу")]
        [Display(Name = "Ціна транспортного засобу")]
        public override decimal Price { get; set; }

        [Display(Name = "Повний опис з характеристиками транспортного засобу")]
        public override string Text { get; set; }
    }
}
