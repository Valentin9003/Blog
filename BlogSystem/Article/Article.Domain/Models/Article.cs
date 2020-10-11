using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Domain.Models
{
    internal class Article
    {
        internal Article()
        {

        }

        public string Title { get; private set; }

        public string Content { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }


    }
}
