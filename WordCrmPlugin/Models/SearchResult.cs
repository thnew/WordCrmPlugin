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
                if (Content.Length > 150)
                {
                    return Content.Substring(0, 150);
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
