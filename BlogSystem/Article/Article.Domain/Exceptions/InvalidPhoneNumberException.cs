﻿using Common.Domain.Exceptions;

namespace Article.Domain.Exceptions
{
    public class InvalidPhoneNumberException : BaseDomainException
    {
        public InvalidPhoneNumberException()
        {
        }

        public InvalidPhoneNumberException(string error) => this.Error = error; 
    }
}
