using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.CategoryValidation
{
    public class UpdateCategoryValidation:AbstractValidator<Category>

    {
        public UpdateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz").MaximumLength(3).WithMessage("Lütfen kategori adını en fazla 30 karekter olarak giriniz").MinimumLength(30).WithMessage("Lütfen kategori adını en az 3 karekter oalrak giriniz").Equal("a").WithMessage("Lütfen Kategori adına a harfi ekleyiniz");
        }
    }
}
