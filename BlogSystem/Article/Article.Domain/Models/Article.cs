using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Domain.Models
{
    internal class Article
    {
        internal Article(string title, string content)
        {
            this.ValidateTitle(title);
            this.ValidateContent(content);
        }

        public string Title { get; private set; }

        public string Content { get; private set; }

        //public string CreatorId { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

        public CreationInfo CreationInfo { get; private set; }

        public Article UpdateContent(string content)
        {
            this.ValidateContent(content);

            this.Content = content;

            return this;
        }

        public Article UpdateTitle(string title)
        {
            this.ValidateContent(title);

            this.Title = title;

            return this;
        }

        private void ValidateContent(string content)
        {
            throw new NotImplementedException();
        }

        private void ValidateTitle(string title)
        {
            throw new NotImplementedException();
        }

    }
}
