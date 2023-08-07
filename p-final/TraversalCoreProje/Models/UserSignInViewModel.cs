using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı İsminizi Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage ="Lütfen Paolanızı Giriniz")]
        public string password { get; set; }
    }
}
