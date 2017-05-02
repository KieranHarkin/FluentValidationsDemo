using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FluentValidationsDemo.Contracts
{
    public class CommunicationDataContract : IValidatableObject
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new CommunicationDataContractValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] {item.PropertyName}));
        }
    }
}
