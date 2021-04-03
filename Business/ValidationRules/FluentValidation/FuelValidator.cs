using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class FuelValidator:AbstractValidator<Fuel>
    {
        public FuelValidator()
        {
            RuleFor(f => f.FuelType).NotEmpty();
        }
    }
}
