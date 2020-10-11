using Common.Domain.Exceptions;

namespace Article.Domain.Exceptions
{
    public class InvalidArticleException: BaseDomainException
    {
        public InvalidArticleException(string error)
        {
            this.Error = error;
        }
    }
}
