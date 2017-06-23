using System;

namespace WordCrmPlugin.Models
{
    class SearchResult
    {
        /// <summary>
        /// The title of the search result
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The content of the search result
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The link of the search result
        /// </summary>
        public Uri Link { get; set; }

        /// <summary>
        /// The text that will be displayed in the search results
        /// </summary>
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

        /// <summary>
        /// The text that will be pasted into the document
        /// </summary>
        public string ContentToPaste
        {
            get
            {
                return $"{Content}\n\nSee {Link} for more details.";
            }
        }
    }
}
