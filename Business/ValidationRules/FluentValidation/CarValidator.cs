using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation.Results;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(5);
            RuleFor(c =>c.ModelYear).GreaterThan(1995);
        }
    }
}
