using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcware.RandomBookmarkReader.BookmarkContainerClasses
{
    /// <summary>
    /// Class containing details of the bookmarks of a browser
    /// </summary>
    internal class BrowserBookmarks
    {
        /// <summary>
        /// Name of the browser
        /// </summary>
        public string BrowserName { get; set; }

        /// <summary>
        /// Root folder for all bookmarks
        /// </summary>
        public BookmarkFolder RootFolder { get; set; } = new BookmarkFolder("Root");
    }
}
