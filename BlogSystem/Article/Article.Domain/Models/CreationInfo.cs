using System;

namespace Article.Domain.Models
{
    internal class CreationInfo
    {
        internal CreationInfo()
        {
                
        }
        
        public DateTime CreatedOn { get; private set; }

        public DateTime ModifiedOn { get; private set; }
    }
}
