using System.Collections.Generic;
using Marcware.RandomBookmarkReader.BookmarkContainerClasses;
using Marcware.RandomBookmarkReader.BookmarkReaders;
using Marcware.RandomBookmarkReader.ExtensionMethods;
using Marcware.RandomBookmarkReader.GeneralClasses;

namespace Marcware.RandomBookmarkReader.BookmarkManager
{
    /// <summary>
    /// Class to handle the reading and randomising of al bookmarks
    /// </summary>
    internal class BookmarkManagerClass
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

        public ProcessResult<List<BookmarkUrl>> GetRandomUrlsFromFolder(string browserId, string folderId, bool doIncludeSubFolders, int itemCount)
        {
            ProcessResult<List<BookmarkUrl>> result = new ProcessResult<List<BookmarkUrl>>();

            // Get the browser
            BrowserBookmarks browser = null;
            if (Browsers.ContainsKey(browserId))
                browser = Browsers[browserId];
            else
                result.AddError($"Unable to find the browser with the id '{browserId}'");

            // Get the folder
            BookmarkFolder folder = null;
            if (result.Success)
                folder = browser.RootFolder.FindBookmarkFolder(folderId);
            if (folder == null)
                result.AddError($"Unable to find folder with the id '{folderId}'");

            // Get the random list of URLs to return
            if (result.Success)
            {
                result.Result = folder
                    .GetAllUrls(doIncludeSubFolders)
                    .TakeRandom(itemCount);
            }

            return result;
        }
    }
}
