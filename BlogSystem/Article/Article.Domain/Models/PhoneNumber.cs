using Article.Domain.Exceptions;
using Common.Domain.Models;
using static Article.Domain.Models.ModelConstants.PhoneNumberConstants;
namespace Article.Domain.Models
{
    internal class PhoneNumber
    {
        internal PhoneNumber(string phoneNumber)
        {
            this.Validate(phoneNumber);

        }

        public string Number{ get; private set; }

        public static implicit operator string(PhoneNumber number) => number.Number;

        public static implicit operator PhoneNumber(string number) => new PhoneNumber(number);

        private void Validate(string phoneNumber)
        {
            Guard.AgainstEmptyString<InvalidPhoneNumberException>(phoneNumber,nameof(Number));
            Guard.ValidateRegex<InvalidPhoneNumberException>(phoneNumber, PhoneNumberRegex, PhoneNumberErrorMessage);
        }
    }
}
