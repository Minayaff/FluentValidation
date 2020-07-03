using FluentValidation;

namespace FluentVald.Models
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Id).NotNull()
                .WithMessage("Zəhmət olmasa 'Id' daxil edin");

            RuleFor(reg => reg.Name).NotEmpty()
                .WithMessage("Zəhmət olmasa 'Ad' daxil edin")
                .MinimumLength(8).WithMessage("minimum 8 simvol uzunluğuna icazə verilir")
                .MaximumLength(50).WithMessage("maksimum 50 simvoldan icazə verilir");

            RuleFor(x => x.Address).NotNull()
                .WithMessage("Zəhmət olmasa 'Addressi' daxil edin")
                .MaximumLength(100).WithMessage("maksimum 100 simvol uzunluğuna icazə verilir");

            RuleFor(x => x.Email)
             .NotEmpty()
             .WithMessage("Zəhmət olmasa 'Emaili' daxil edin")
             .EmailAddress()
             .WithMessage("Invalid email format.");

            RuleFor(x => x.Age).NotNull()
                .WithMessage("Zəhmət olmasa 'Yaş' daxil edin")
                .InclusiveBetween(18, 60)
                .WithMessage("Yaş '18 ilə 60 arasında olmalıdır"); ;

            RuleFor(x => x.Salary)
                .NotNull().WithMessage("Zəhmət olmasa 'Maaşı' daxil edin"); ;
        }
    }
}
