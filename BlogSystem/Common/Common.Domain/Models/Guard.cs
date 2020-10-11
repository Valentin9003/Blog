using Common.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Common.Domain.Models
{
    public static class Guard
    {
        public static void AgainstStringLength<TException>(string text,int minLength, int maxLength, string propertyName)
            where TException : BaseDomainException, new()
        {
            if (text.Length > maxLength && text.Length < minLength)
            {
                return;
            }

            ThrowException<TException>($"{propertyName} length must be in range between {minLength} and {maxLength}");
        }

        public static void AgainstEmptyString<TException>(string text, string propertyName)
            where TException : BaseDomainException, new()
        {
            if (!String.IsNullOrEmpty(text))
            {
                return;
            }

            ThrowException<TException>($"{propertyName} can not be empty");
        }

        public static void ValidateRegex<TException>(string text, string regex, string specificMessage)
          where TException : BaseDomainException, new()
        {
            if (Regex.IsMatch(text, regex))
            {
                return;
            }

            ThrowException<TException>(specificMessage);
        }

        private static void ThrowException<TException>(string error)
            where TException : BaseDomainException, new()
        {
            var exception = new TException
            {
                Error = error
            };

            throw exception;
        }
    }
}
