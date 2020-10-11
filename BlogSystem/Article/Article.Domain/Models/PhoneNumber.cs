using Article.Domain.Exceptions;
using Common.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Article.Domain.Models.ModelConstants.PhoneNumberConstants;
namespace Article.Domain.Models
{
    internal class PhoneNumber
    {
        internal PhoneNumber()
        {

        }

        public string Phone { get; private set; }

        private void Validate(string phoneNumber)
        {
            Guard.ValidateRegex<InvalidPhoneNumberException>(phoneNumber, PhoneNumberRegex, "Phone number must start with a '+' and contain only digits afterwards.");
        }
    }
}
