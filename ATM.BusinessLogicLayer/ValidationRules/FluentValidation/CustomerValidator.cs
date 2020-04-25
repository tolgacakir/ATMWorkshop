using ATM.Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer.ValidationRules.FluentValidation
{
    public class CustomerValidator :AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Username).NotNull();
            RuleFor(c => c.Username).NotEmpty();
            RuleFor(c => c.Username).MinimumLength(1).WithMessage("Username's length must be greater than 1");
            RuleFor(c => c.Username).MaximumLength(5).WithMessage("Username's length must be smaller than 5");

            RuleFor(c => c.Password).NotEmpty();
            
        }
    }
}
