using System;

namespace week2.day12
{
    class BlogPost
    {
        private readonly string _authorName;
        private readonly string _title;
        private readonly string _text;
        private readonly string _publicationDate;

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            _authorName = authorName;
            _title = title;
            _text = text;
            _publicationDate = publicationDate;
        }

        public string PrintBlogPost()
        {
            return $"{_title} titled by {_authorName} posted at {_publicationDate}. {Environment.NewLine} {_text}.";
        }
    }
}