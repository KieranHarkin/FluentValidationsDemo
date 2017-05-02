using FluentValidation;

namespace FluentValidationsDemo.Contracts
{
    public class CommunicationDataContractValidator : AbstractValidator<CommunicationDataContract>
    {
        public CommunicationDataContractValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("First Name cannot be empty");
            RuleFor(c => c.Name).Length(5, 15);

            RuleFor(c => c.Description).NotEmpty().WithMessage("Description cannot be empty");
        }
    }
}
