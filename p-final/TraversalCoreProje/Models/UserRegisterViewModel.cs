using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen İsminizi Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyisminizi Giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı İsminizi Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen E-Posta Adresini Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Parolalar Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
    }
}
