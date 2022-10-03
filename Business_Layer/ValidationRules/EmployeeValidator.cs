using Entity_Layer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Personel adı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Personel şifresi boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Personel mail boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Personel soyadı boş geçilemez");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Personel cinsiyet boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri giriniz");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri giriniz");
        }
    }
}
