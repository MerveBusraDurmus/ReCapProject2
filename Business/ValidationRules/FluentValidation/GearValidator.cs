using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class GearValidator:AbstractValidator<Gear>
    {
        public GearValidator()
        {
            RuleFor(g => g.GearType).NotEmpty();
        }
    }
}
