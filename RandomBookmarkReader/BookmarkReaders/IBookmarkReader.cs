using Marcware.RandomBookmarkReader.BookmarkContainerClasses;
using Marcware.RandomBookmarkReader.GeneralClasses;

namespace Marcware.RandomBookmarkReader.BookmarkReaders
{
    /// <summary>
    /// Core interface for the reading of the bookmarks from a browser
    /// </summary>
    internal interface IBookmarkReader
    {
        /// <summary>
        /// Return a collection of bookmarks for this browser
        /// </summary>
        /// <returns></returns>
        ProcessResult<BrowserBookmarks> GetBookmarks();
    }
}
