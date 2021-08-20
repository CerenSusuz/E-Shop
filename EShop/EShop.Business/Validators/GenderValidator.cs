using EShop.Business.Models;
using FluentValidation;

namespace EShop.Business.Validators
{
    public class GenderValidator : AbstractValidator<GenderDto>
    {
        public GenderValidator()
        {
            RuleFor(x => x.Description).NotNull().Length(1, 100);
        }
    }
}