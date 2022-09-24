using Entity_Layer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçilemez");
            RuleFor(x => x.PurchasePrice).NotEmpty().WithMessage("Fiyat bilgisi boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("lütfen 50 karakterden daha kısa bir isim giriniz");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");
        }
    }
}
