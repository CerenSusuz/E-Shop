using EShop.Business.Models;
using FluentValidation;

namespace EShop.Business.Validators
{
    public class UserGroupValidator: AbstractValidator<UserGroupDto>
    {
        public UserGroupValidator()
        {
            RuleFor(x => x.Description).NotNull().Length(1, 100);
        }
    }
}