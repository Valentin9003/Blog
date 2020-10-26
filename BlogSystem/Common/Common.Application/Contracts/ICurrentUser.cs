using System.Collections.Generic;

namespace Common.Application.Contracts
{
    public interface ICurrentUser
    {
        string UserId { get; }

        IEnumerable<string> Roles { get; }
    }
}
