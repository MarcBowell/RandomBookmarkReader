using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Marcware.RandomBookmarkReader.BookmarkContainerClasses;
using Marcware.RandomBookmarkReader.GeneralClasses;
using Newtonsoft.Json;

namespace Marcware.RandomBookmarkReader.BookmarkReaders
{
    internal class ChromeBookmarkReader : IBookmarkReader
    {
        #region Chrome bookmark json objects
        private class ChromeMainNode
        {
            public string checksum { get; set; }
            public string version { get; set; }
            public ChromeRootsNode roots { get; set; }
        }

        private class ChromeRootsNode
        {
            public ChromeItemNode bookmark_bar { get; set; }
            public ChromeItemNode other { get; set; }
        }

        private class ChromeItemNode
        {
            public string date_added { get; set; }
            public string guid { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public List<ChromeItemNode> children { get; set; }
        }

        private static class ChromeItemTypes
        {
            public const string Url = "url";
            public const string Folder = "folder";
        }
        #endregion

        public ProcessResult<BrowserBookmarks> GetBookmarks()
        {
            ProcessResult<BrowserBookmarks> result = new ProcessResult<BrowserBookmarks>();
            string bookmarkFile = GetBookmarkFilename();
            ChromeMainNode mainNode = GetChromeBookmarkJson(bookmarkFile);
            result.Result = GetBrowserBookmarks(mainNode);
            return result;
        }

        private string GetBookmarkFilename()
        {
            const string chromeFilenameKey = "Chrome.BookmarksFile";
            string result = ConfigurationManager.AppSettings[chromeFilenameKey];
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //TODO: Add some other configuration options here for local paths
            result = result.Replace("{CurrentUser.LocalApplicationDataPath}", appDataPath);
            return result;
        }

        private ChromeMainNode GetChromeBookmarkJson(string bookmarksFilename)
        {
            string bookmarksJson = File.ReadAllText(bookmarksFilename);
            ChromeMainNode result = JsonConvert.DeserializeObject<ChromeMainNode>(bookmarksJson);
            return result;
        }

        private BrowserBookmarks GetBrowserBookmarks(ChromeMainNode mainNode)
        {
            BrowserBookmarks result = new BrowserBookmarks();
            result.BrowserName = "Google Chrome";
            if (mainNode.roots?.bookmark_bar != null && mainNode.roots.bookmark_bar.children.Count > 0)
            {
                result.RootFolder.SubFolders.Add(GetBookmarkFolder(mainNode.roots.bookmark_bar));
            }
            if (mainNode.roots?.other != null && mainNode.roots.other.children.Count > 0)
            {
                result.RootFolder.SubFolders.Add(GetBookmarkFolder(mainNode.roots.other));
            }
            return result;
        }

        private BookmarkFolder GetBookmarkFolder(ChromeItemNode folder)
        {
            BookmarkFolder result = new BookmarkFolder(folder.name);

            foreach (ChromeItemNode child in folder.children)
            {
                switch (child.type)
                {
                    case ChromeItemTypes.Url:
                        result.Urls.Add(new BookmarkUrl(child.name, child.url));
                        break;
                    case ChromeItemTypes.Folder:
                        if (folder.children.Count > 0)
                        {
                            result.SubFolders.Add(GetBookmarkFolder(child));
                        }
                        break;
                }
            }

            // File is in C:\Users\marcb\AppData\Local\Google\Chrome\User Data\Default
            return result;
        }
    }
}
