﻿using System.ComponentModel.DataAnnotations;

namespace TarasDzivikPetProject.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логін")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати мене на цьому сайті?")]
        public bool RememberMe { get; set; }
    }
}