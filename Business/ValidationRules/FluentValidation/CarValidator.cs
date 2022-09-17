using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Araba açıklaması boş olamaz.");
            RuleFor(x => x.Description).MinimumLength(2).WithMessage("Araba açıklaması en az iki karakter içermelidir.");

            RuleFor(x => x.DailyPrice).NotEmpty().WithMessage("Günlük ücret boş olamaz.");
            RuleFor(x => x.DailyPrice).GreaterThan(0).WithMessage("Günlük ücret sıfırdan büyük olmalıdır.");
        }
    }
}
