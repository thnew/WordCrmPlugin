using System;

namespace WordCrmPlugin.Models
{
    class SearchResult
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string ShortDescription
        {
            get
            {
                var maxLength = 150;
                if (Content.Length > maxLength)
                {
                    return $"{Content.Substring(0, maxLength - 3)}...";
                }

                return Content;
            }
        }

        public string ContentToPaste
        {
            get
            {
                return $"{Content}\n\nSee {Link} for more details.";
            }
        }

        public Uri Link { get; set; }
    }
}
