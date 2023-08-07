using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("E-Posta Alanı Boş Geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı İsmi Alanı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola Alanı Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Parola Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("lütfen En Az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("lütfen En Gazla 20 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Parolalar Birbiriyle Uyuşmuyor");
        }
    }
}
