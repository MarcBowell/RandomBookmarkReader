using System.Collections.Generic;
using Marcware.RandomBookmarkReader.BookmarkContainerClasses;
using Marcware.RandomBookmarkReader.BookmarkReaders;
using Marcware.RandomBookmarkReader.GeneralClasses;

namespace Marcware.RandomBookmarkReader.BookmarkManager
{
    /// <summary>
    /// Class to handle the reading and randomising of al bookmarks
    /// </summary>
    internal class BookmarkManager
    {
        public Dictionary<string, BrowserBookmarks> Browsers { get; set; }

        /// <summary>
        /// Read the bookmarks from all folders
        /// </summary>
        /// <returns></returns>
        public ProcessResult<Dictionary<string, BrowserBookmarks>> GetBookmarksFromAllBrowsers()
        {
            Browsers = new Dictionary<string, BrowserBookmarks>();
            ProcessResult<Dictionary<string, BrowserBookmarks>> result = new ProcessResult<Dictionary<string, BrowserBookmarks>>();

            //TODO: Get results from other browsers
            IBookmarkReader chromeReader = new ChromeBookmarkReader();
            ProcessResult<BrowserBookmarks> chromeResult = chromeReader.GetBookmarks();
            if (chromeResult.Success)
            {
                Browsers.Add(chromeResult.Result.BrowserName, chromeResult.Result);
                result.Result = Browsers;
            }
            else
            {
                result.Success = false;
                result.ErrorMessage = chromeResult.ErrorMessage;
            }

            return result;            
        }
    }
}
