using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace FluentValidationsDemo.Data_Contracts
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
