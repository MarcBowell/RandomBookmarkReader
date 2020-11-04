namespace Marcware.RandomBookmarkReader.BookmarkContainerClasses
{
    /// <summary>
    /// Class containing information about a URL
    /// </summary>
    internal class BookmarkUrl
    {
        public BookmarkUrl(string urlName, string url)
        {
            UrlName = urlName;
            Url = url;
        }

        /// <summary>
        /// Display name for the Url
        /// </summary>
        public string UrlName { get; set; }

        /// <summary>
        /// URL of the web page
        /// </summary>
        public string Url { get; set; }
    }
}
